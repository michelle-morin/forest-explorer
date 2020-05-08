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

  const [selectedSegment, changeSelectedSegment] = useState(null);
  const [selectedTarget, changeTarget] = useState(null)
  // const [otherSegmentsOfSameName, getCompleteTrail] = useState(null);

  const featureStyle = {
    color: '#749774'
  }
  const popupOptions = {
    className: 'custom-popup'
  }

  const highlightTrail = (feature) => {
    return {
      color: '#111111'
    }
  };

  const deselectTrail = (feature) => {
    return {
      color: '#749774'
    }
  }

  const onEachFeature = (feature, layer) => {
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
        if (selectedTarget !== null) {
          selectedTarget.setStyle(deselectTrail());
        }
        layer.setStyle(highlightTrail());
        changeTarget(layer);
        changeSelectedSegment(event.target.feature);
      }
    });
  };

    return (
      <Map center={[45.5252, -122.7163]} zoom={13}>
        <TileLayer 
          url="https://cartodb-basemaps-{s}.global.ssl.fastly.net/light_all/{z}/{x}/{y}.png"
          maxZoom={20}
        />
        <GeoJSON id="trailLayer" data={trailData} style={featureStyle} onEachFeature={onEachFeature} />
      </Map>
    );
  }

export default TrailMap;