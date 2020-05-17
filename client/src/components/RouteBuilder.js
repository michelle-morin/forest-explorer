import React from 'react';
import { connect } from 'react-redux';
import { getAllTrailsFromApi } from '../actions';
import { Map, TileLayer, GeoJSON } from 'react-leaflet';
import { trailData } from '../data/trails.js';
import styled from 'styled-components';
import { Button } from 'react-bootstrap';
import '../index.css';

const SideBar = styled.div`
  width: ${props => props.width};
  height: ${props => props.height};
  position: absolute;
  z-index: 10000;
  top: 15vh;
  left: 75vw;
  background-color: rgb(250,250,248);
  border-radius: 10px;
  border: 1px solid  #D5D6DC;
  box-shadow: 0 6px 12px 0 rgba(0,0,0,0.25), 0 6px 12px 0 rgba(0,0,0,0.22);
  padding: 3%;
`;

const ButtonWrapper = styled.div`
  display: flex;
  justify-content: space-around;
`;

const routeStyle = {
  color: 'rgb(204,65,118)'
}
const featureStyle = {
  color: 'rgb(73,161,105)'
}
const hoverStyle = {
  color: 'rgb(246,189,111)'
}
const selectedStyle = {
  color: 'rgb(117,165,224)'
}
const popupOptions = {
  className: 'custom-popup'
}

class RouteBuilder extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      selectedTarget: null,
      selectedGeoId: null,
      verifiedRoute: [],
      layersInRoute: [],
      distance: 0
    }
  }

  componentDidMount() {
    const { dispatch } = this.props;
    dispatch(getAllTrailsFromApi());
  }

  showRouteDetails() {
    if (this.state.verifiedRoute.length > 0) {
      const roundedDistance = this.state.distance.toFixed(3);
      return (
        <React.Fragment>
        <h3>Current route:</h3>
        <ul>
          {(this.state.verifiedRoute).map(segment =>
            <li key={segment.trailId}>{segment.name}</li>
          )}
        </ul>
        <p>{roundedDistance} miles</p>
        </React.Fragment>
      );
    }
  }

  deleteRoute() {
    (this.state.layersInRoute).map(layer => layer.setStyle(featureStyle));
    this.setState({selectedTarget: null, selectedGeoId: null, verifiedRoute: [], layersInRoute: [], distance: 0});
  }

  showDeleteButton() {
    return (this.state.verifiedRoute.length > 0) ? <Button variant="outline-dark" onClick={() => this.deleteRoute()}>DELETE ROUTE</Button> : null
  }

  render() {
    const { isLoading, trails, error } = this.props;

    const renderCurrentRoute = () => {
      (this.state.layersInRoute).map(layer => layer.setStyle(routeStyle))
    }

    const determineIfSegmentCanBeAdded = (objNum) => {
      const segmentArr = trails.filter(trail => trail.geoObjNumber === objNum);
      const segment = segmentArr[0];
      if (this.state.verifiedRoute.length === 0) {
        return true;
      } else if (this.state.verifiedRoute.length === 1) {
        const existingSegment = this.state.verifiedRoute[0];
        if ((existingSegment.firstAdjoiningSegment1 === segment.geoObjNumber) || (existingSegment.firstAdjoiningSegment2 === segment.geoObjNumber) || (existingSegment.firstAdjoiningSegment3 === segment.geoObjNumber) || (existingSegment.firstAdjoiningSegment4 === segment.geoObjNumber) || (existingSegment.secondAdjoiningSegment1 === segment.geoObjNumber) || (existingSegment.secondAdjoiningSegment2 === segment.geoObjNumber) || (existingSegment.secondAdjoiningSegment3 === segment.geoObjNumber) || (existingSegment.secondAdjoiningSegment4 === segment.geoObjNumber)) {
          return true;
        } else {
          return false;
        }
      } else {
        for (let i=0; i< this.state.verifiedRoute.length; i++) {
          if ((this.state.verifiedRoute[i].firstAdjoiningSegment1 === segment.geoObjNumber) || (this.state.verifiedRoute[i].firstAdjoiningSegment2 === segment.geoObjNumber) || (this.state.verifiedRoute[i].firstAdjoiningSegment3 === segment.geoObjNumber) || (this.state.verifiedRoute[i].firstAdjoiningSegment4 === segment.geoObjNumber) || (this.state.verifiedRoute[i].secondAdjoiningSegment1 === segment.geoObjNumber) || (this.state.verifiedRoute[i].secondAdjoiningSegment2 === segment.geoObjNumber) || (this.state.verifiedRoute[i].secondAdjoiningSegment3 === segment.geoObjNumber) || (this.state.verifiedRoute[i].secondAdjoiningSegment4 === segment.geoObjNumber)) {
            return true;
          }
        }
        return false;
      }
    }

    const handleAddingSegmentToRoute = (objNum, target) => {
      const segmentArr = trails.filter(trail => trail.geoObjNumber === objNum);
      const segment = segmentArr[0];
      const currentRoute = this.state.verifiedRoute;
      currentRoute.push(segment);
      const currentLayers = this.state.layersInRoute;
      currentLayers.push(target);
      const newDistance = this.state.distance + segment.miles;
      this.setState({
        verifiedRoute: currentRoute, 
        layersInRoute: currentLayers, 
        distance: newDistance
      });
      renderCurrentRoute();
    }

    const showAddTrailButton = () => {
      return (this.state.selectedTarget !== null && determineIfSegmentCanBeAdded(this.state.selectedGeoId)) ? <Button variant="outline-dark" onClick={() => handleAddingSegmentToRoute(this.state.selectedGeoId, this.state.selectedTarget)}>+ ADD TO ROUTE</Button> : null
    }

    if (error) {
      return <React.Fragment>Error: {error.message}</React.Fragment>
    } else if (isLoading) {
      return <React.Fragment>Loading...</React.Fragment>
    } else {
      const onEachFeature = (feature, layer) => {
        const popupContent = `
          ${feature.properties.Name}
        `;
        layer.setStyle(featureStyle);
        layer.bindPopup(popupContent, popupOptions);
        layer.on({
          'mouseover': (event) => {
            if (layer !== this.state.selectedTarget) {
              layer.setStyle(hoverStyle);
            }
          },
          'click': (event) => {
            if (this.state.selectedTarget !== null) {
              this.state.selectedTarget.setStyle(featureStyle);
            }
            layer.setStyle(selectedStyle);
            this.setState({selectedTarget: layer, selectedGeoId: feature.properties.GeoObjNumber});
          },
          'mouseout': (event) => {
            if (layer !== this.state.selectedTarget) {
              layer.setStyle(featureStyle);
            }
          }
        });
      };

      return (
        <React.Fragment>
          <Map center={[45.545, -122.7163]} zoom={14}>
            <TileLayer 
              url="https://cartodb-basemaps-{s}.global.ssl.fastly.net/light_all/{z}/{x}/{y}.png"
              maxZoom={20}
            />
            <GeoJSON id="trailLayer" data={trailData} onEachFeature={onEachFeature} />
          </Map>
          <SideBar width="20vw" height="70vh">
            <ButtonWrapper>
              {showAddTrailButton()}
              {this.showDeleteButton()}
            </ButtonWrapper>
            {this.showRouteDetails()}
          </SideBar>
        </React.Fragment>
      )
    }
  }
}

const mapStateToProps = state => {
  return {
    isLoading: state.isLoading,
    trails: state.trails,
    error: state.error
  }
}

export default connect(mapStateToProps)(RouteBuilder);