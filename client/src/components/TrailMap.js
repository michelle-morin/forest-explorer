import React, { setState } from 'react';
import { Map, TileLayer, GeoJSON } from 'react-leaflet';
import { trailData } from '../data/data.js';
// import styled from 'styled-components';
import '../index.css';

// const Wrapper = styled.div`
//   width: ${props => props.width};
//   height: ${props => props.height};
// `;

const featureStyle = {
  color: '#749774'
}

const popupOptions = {
  className: 'custom-popup'
}

class TrailMap extends React.Component {

  constructor(props) {
    super(props);
    this.state = {
      selectedSegment: null,
      otherSegmentsOfSameName: null
    }
  }

  selectTrail = (feature) => {
    return {
      color: '#111111'
    }
  };

  deselectTrail = (feature) => {
    return {
      color: '#749774'
    }
  }

  onEachFeature = (feature, layer) => {
    const popupContent = `
      <strong>${feature.properties.Name}</strong><br/>
      ${feature.properties.Type}<br/>
      surface: ${feature.properties.Surface}<br/>
      ${feature.properties.Miles} miles
    `;
    layer.bindPopup(popupContent, popupOptions);
    layer.on({
      // 'mouseover': function (event) {
      //   changeColor(event.target);
      // },
      // 'mouseout': function (event) {
      //   resetColor(event.target);
      // },
      'click': (event) => {
        if (this.selectedSegment != null) {
          const activeTrail = this.selectedSegment;
          activeTrail.setStyle(this.deselectTrail(activeTrail));
        }
        let selection = event.target;
        this.setState({selectedSegment: selection});
        selection.setStyle(this.selectTrail(selection));
      }
    });
  };

  render() {
    return (
      <Map center={[45.5252, -122.7163]} zoom={13}>
        <TileLayer 
          url="https://cartodb-basemaps-{s}.global.ssl.fastly.net/light_all/{z}/{x}/{y}.png"
          maxZoom={20}
        />
        <GeoJSON data={trailData} style={featureStyle} onEachFeature={this.onEachFeature} />
      </Map>
    );
  }
}

export default TrailMap;