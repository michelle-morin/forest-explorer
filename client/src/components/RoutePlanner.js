import React from 'react';
import { connect } from 'react-redux';
import { getAllTrailsFromApi } from './../actions';
import { Map, TileLayer, GeoJSON } from 'react-leaflet';
import { trailData } from '../data/data.js';
import styled from 'styled-components';
import '../index.css';

const SideBar = styled.div`
  width: ${props => props.width};
  height: ${props => props.height};
  position: absolute;
  top: 0;
  left: 70%;
`;

class RoutePlanner extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      selectedTarget: null,
      selectedGeoId: null,
      verifiedRoute: [],
      distance: 0
    }
  }

  componentDidMount() {
    const { dispatch } = this.props;
    dispatch(getAllTrailsFromApi());
  }

  showRouteDetails() {
    if (this.state.verifiedRoute.length > 0) {
      return (
        <React.Fragment>
        <h3>Current route:</h3>
        <ul>
          {(this.state.verifiedRoute).map(segment => 
            <li key={segment.trailId}>{segment.name}</li>
          )}
        </ul>
        <p>{this.state.distance} miles</p>
        </React.Fragment>
      );
    }
  }

  deleteRoute() {
    this.setState({selectedTarget: null, selectedGeoId: null, verifiedRoute: [], distance: 0});
  }

  showDeleteButton() {
    return (this.state.verifiedRoute.length > 0) ? <button onClick={() => this.deleteRoute()}>START OVER</button> : null
  }

  // showAddTrailButton() {
  //   return (this.state.selectedTarget !== null) ? <button onClick={() => handleAddingSegmentToRoute(this.state.selectedGeoId)}>+ ADD TO ROUTE</button> : null
  // }

  render() {
    const { isLoading, trails, error } = this.props;

    const handleAddingSegmentToRoute = (id) => {
      const currentRoute = this.state.verifiedRoute;
      const segmentArr = trails.filter(trail => trail.geoObjNumber === id);
      const segment = segmentArr[0];
      console.log(segment);
      console.log(this.state.verifiedRoute);
      if (currentRoute.length === 0) {
        currentRoute.push(segment);
        const newDistance = this.state.distance + segment.miles;
        this.setState({verifiedRoute: currentRoute, distance: newDistance});
        console.log("added to route!");
      } else if (currentRoute.length === 1) {
        const existingSegment = currentRoute[0];
        if ((existingSegment.firstAdjoiningSegment1 === segment.geoObjNumber) || (existingSegment.firstAdjoiningSegment2 === segment.geoObjNumber) || (existingSegment.firstAdjoiningSegment3 === segment.geoObjNumber) || (existingSegment.firstAdjoiningSegment4 === segment.geoObjNumber) || (existingSegment.secondAdjoiningSegment1 === segment.geoObjNumber) || (existingSegment.secondAdjoiningSegment2 === segment.geoObjNumber) || (existingSegment.secondAdjoiningSegment3 === segment.geoObjNumber) || (existingSegment.secondAdjoiningSegment4 === segment.geoObjNumber)) {
          currentRoute.push(segment);
          const newDistance = this.state.distance + segment.miles;
          this.setState({verifiedRoute: currentRoute, distance: newDistance});
        } else {
          console.log("segment could not be added")
        }
      } else if (currentRoute.length > 1) {
        for (let i=0; i< currentRoute.length; i++) {
          if ((currentRoute[i].firstAdjoiningSegment1 === segment.geoObjNumber) || (currentRoute[i].firstAdjoiningSegment2 === segment.geoObjNumber) || (currentRoute[i].firstAdjoiningSegment3 === segment.geoObjNumber) || (currentRoute[i].firstAdjoiningSegment4 === segment.geoObjNumber) || (currentRoute[i].secondAdjoiningSegment1 === segment.geoObjNumber) || (currentRoute[i].secondAdjoiningSegment2 === segment.geoObjNumber) || (currentRoute[i].secondAdjoiningSegment3 === segment.geoObjNumber) || (currentRoute[i].secondAdjoiningSegment4 === segment.geoObjNumber)) {
            currentRoute.push(segment);
            const newDistance = this.state.distance + segment.miles;
            this.setState({verifiedRoute: currentRoute, distance: newDistance});
            return;
          }
        }
        console.log("could not add segment"); 
      }
    }

    if (error) {
      return <React.Fragment>Error: {error.message}</React.Fragment>
    } else if (isLoading) {
      return <React.Fragment>Loading...</React.Fragment>
    } else {
      const featureStyle = {
        color: '#749774'
      }
      const hoverStyle = {
        color: '#d4af37'
      }
      const selectedStyle = {
        color: '#0d120d'
      }
      const popupOptions = {
        className: 'custom-popup'
      }
  
      const onEachFeature = (feature, layer) => {
        const popupContent = `
          <strong>${feature.properties.Name}</strong><br/>
          ${feature.properties.Type}<br/>
          surface: ${feature.properties.Surface}<br/>
          ${feature.properties.Miles} miles
        `;
        layer.setStyle(featureStyle);
        layer.bindPopup(popupContent, popupOptions);
        layer.on({
          'mouseover': (event) => {
            layer.setStyle(hoverStyle);
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
          <Map className="route-map" center={[45.545, -122.7163]} zoom={15}>
            <TileLayer 
              url="https://cartodb-basemaps-{s}.global.ssl.fastly.net/light_all/{z}/{x}/{y}.png"
              maxZoom={20}
            />
            <GeoJSON id="trailLayer" data={trailData} onEachFeature={onEachFeature} />
          </Map>
          <SideBar width="30%" height="100vh">
            <button onClick={() => handleAddingSegmentToRoute(this.state.selectedGeoId)}>+ ADD TO ROUTE</button>
            {this.showDeleteButton()}
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

export default connect(mapStateToProps)(RoutePlanner);