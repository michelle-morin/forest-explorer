import React from 'react';
import { connect } from 'react-redux';
import { getAllTrailsFromApi } from '../actions';
import { Map, TileLayer, GeoJSON } from 'react-leaflet';
import { trailData } from '../data/trails.js';
import styled from 'styled-components';
import { Button } from 'react-bootstrap';
import SurfaceChart from './SurfaceChart';
import '../index.css';

const SideBar = styled.div`
  width: ${props => props.width};
  height: ${props => props.height};
  position: absolute;
  z-index: 10000;
  top: 15vh;
  left: 65vw;
  background-color: rgb(255,255,255, .75);
  border-radius: 10px;
  border: 1px solid  #D5D6DC;
  box-shadow: 0 6px 12px 0 rgba(0,0,0,0.25), 0 6px 12px 0 rgba(0,0,0,0.22);
  padding: 3%;
`;

const ButtonWrapper = styled.div`
  display: flex;
  justify-content: space-between;
  padding: 4%;
  font-family: 'Montserrat', sans-serif;
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
  color: 'rgb(204,65,118)'
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

  generateChartData = () => {
    const surfaces = [];
    const route = this.state.verifiedRoute;
    for (let i=0; i < route.length; i++) {
      let match = surfaces.filter(obj => obj.x === route[i].surface);
      if (match.length === 0) {
        let surfaceObj = { x: route[i].surface, y: route[i].miles };
        surfaces.push(surfaceObj);
      } else if (match.length === 1) {
        console.log(match);
        const updatedMatch = { x: match[0].x, y: (match[0].y + route[i].miles) }
        const index = surfaces.findIndex(obj => obj.x === route[i].surface);
        surfaces.splice(index, 1, updatedMatch);
      }
    }
    return surfaces;
  }

  showInstructions() {
    if(this.state.verifiedRoute.length === 0) {
      return (
        <center><h3 className="instructions">select a trail, then click add to route</h3></center>
      );
    }
  }

  showRouteDetails() {
    if (this.state.verifiedRoute.length > 0) {
      const chartData = this.generateChartData();
      return (
        <SurfaceChart
          data={chartData}
          totalDistance={this.state.distance}
        />
      );
    }
  }

  deleteRoute() {
    (this.state.layersInRoute).map(layer => layer.setStyle(featureStyle));
    this.setState({selectedTarget: null, selectedGeoId: null, verifiedRoute: [], layersInRoute: [], distance: 0});
  }

  showDeleteButton() {
    return (this.state.verifiedRoute.length > 0) ? <Button variant="outline-dark" onClick={() => this.deleteRoute()}>DELETE ROUTE</Button> : <Button variant="outline-dark" disabled={true}>DELETE ROUTE</Button>
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
      return (this.state.selectedTarget !== null && determineIfSegmentCanBeAdded(this.state.selectedGeoId)) ? <Button variant="outline-dark" onClick={() => handleAddingSegmentToRoute(this.state.selectedGeoId, this.state.selectedTarget)}>+ ADD TO ROUTE</Button> : <Button variant="outline-dark" disabled={true}>+ ADD TO ROUTE</Button>
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
          <Map center={[45.57, -122.7163]} zoom={13} zoomControl={false}>
            <TileLayer 
              url="http://d.sm.mapstack.stamen.com/(toner-background,(watercolor,$000[@20])[lighter],terrain-background[overlay])/{z}/{x}/{y}.png"
              maxZoom={19}
            />
            <GeoJSON id="trailLayer" data={trailData} onEachFeature={onEachFeature} />
          </Map>
          <SideBar width="30vw" height="auto">
            {this.showInstructions()}
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