import React from 'react';
import { Map, TileLayer, GeoJSON } from 'react-leaflet';
import { trailData } from '../data/data.geojson';
// import styled from 'styled-components';
import '../index.css';

// const Wrapper = styled.div`
//   width: ${props => props.width};
//   height: ${props => props.height};
// `;

export default function TrailMap() {
  return (
    <Map center={[45.5252, -122.7163]} zoom={13}>
      <TileLayer 
        url="https://cartodb-basemaps-{s}.global.ssl.fastly.net/light_all/{z}/{x}/{y}.png"
        maxZoom={20}
      />
      <GeoJSON data={trailData} />
    </Map>
  );
}