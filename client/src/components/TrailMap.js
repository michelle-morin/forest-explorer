import React, { useState } from 'react';
import { Map, TileLayer, GeoJSON } from 'react-leaflet';
import { trailData } from '../data/data.js';
// import styled from 'styled-components';
import '../index.css';

// const Wrapper = styled.div`
//   width: ${props => props.width};
//   height: ${props => props.height};
// `;

function TrailMap() {

  const [selectedTarget, changeTarget] = useState(null)
  // const [otherSegmentsOfSameName, getCompleteTrail] = useState(null);

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
      'mouseover': function (event) {
        layer.setStyle(hoverStyle);
      },
      'click': (event) => {
        if (selectedTarget !== null) {
          selectedTarget.setStyle(featureStyle);
        }
        layer.setStyle(selectedStyle);
        changeTarget(layer);
      },
      'mouseout': function (event) {
        if (layer !== selectedTarget) {
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

export default TrailMap;