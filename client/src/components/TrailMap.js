import React from 'react';
import L from 'leaflet';
import { Map, TileLayer, GeoJSON } from 'react-leaflet';
import { trailData } from '../data/trails.js';
import { trailheads } from '../data/trailheads.js';
import { hoytAndWashParkTrails } from '../data/washPark.js';
import tree from './../assets/img/tree.png';
import '../index.css';

delete L.Icon.Default.prototype._getIconUrl;

L.Icon.Default.mergeOptions({
  iconRetinaUrl: require('leaflet/dist/images/marker-icon-2x.png'),
  iconUrl: require('leaflet/dist/images/marker-icon.png'),
  shadowUrl: require('leaflet/dist/images/marker-shadow.png')
});

const treeIcon = new L.Icon({
  iconUrl: tree,
  iconSize: [20, 30]
});

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
      color: '#654321'
    }
    const popupOptions = {
      className: 'custom-popup'
    }

    const onEachTrailFeature = (feature, layer) => {
      const popupContent = `
        <center><strong>${feature.properties.Name}</strong><br/>
        ${feature.properties.Type}<br/>
        surface: ${feature.properties.Surface}<br/>
        ${feature.properties.Miles} miles</center>
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

    const onEachTrailheadFeature = (feature, layer) => {
      const popupTrailheadContent = `
        <center><strong>${feature.properties.Name}</strong><br/>
        ${feature.properties.Type}<br/>
        ${feature.properties.Description}</center>
      `;
      layer.bindPopup(popupTrailheadContent, popupOptions);
    };

    const pointToLayer = (feature, latlng) => {
      return L.marker(latlng, {
        icon: treeIcon
      });
    };
    
    return (
      <Map center={[45.57, -122.7163]} zoomControl={false} zoom={13}>
        <TileLayer 
          url="http://d.sm.mapstack.stamen.com/(toner-background,(watercolor,$000[@20])[lighter],terrain-background[overlay])/{z}/{x}/{y}.png"
          maxZoom={19}
        />
        <GeoJSON id="trailLayer" data={trailData} onEachFeature={onEachTrailFeature} />
        <GeoJSON id="hwTrailLayer" data={hoytAndWashParkTrails} onEachFeature={onEachTrailFeature} />
        <GeoJSON id="trailheadLayer" data={trailheads} pointToLayer={pointToLayer} onEachFeature={onEachTrailheadFeature} />
      </Map>
    );
  }
}

export default TrailMap;