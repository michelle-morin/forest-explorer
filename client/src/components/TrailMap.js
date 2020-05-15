import React from 'react';
import { Map, TileLayer, GeoJSON } from 'react-leaflet';
import { trailData } from '../data/data.js';
import '../index.css';

class TrailMap extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      selectedTarget: null
    }
  }

  render() {
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
          if (layer !== this.state.selectedTarget) {
            layer.setStyle(hoverStyle);
          }
        },
        'click': (event) => {
          if (this.state.selectedTarget !== null) {
            this.state.selectedTarget.setStyle(featureStyle);
          }
          layer.setStyle(selectedStyle);
          this.setState({selectedTarget: layer});
        },
        'mouseout': (event) => {
          if (layer !== this.state.selectedTarget) {
            layer.setStyle(featureStyle);
          }
        }
      });
    };
    
    return (
      <Map center={[45.545, -122.7163]} zoom={14}>
        <TileLayer 
          url="https://cartodb-basemaps-{s}.global.ssl.fastly.net/light_all/{z}/{x}/{y}.png"
          maxZoom={20}
        />
        <GeoJSON id="trailLayer" data={trailData} onEachFeature={onEachFeature} />
      </Map>
    );
  }
}

export default TrailMap;