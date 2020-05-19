import React from 'react';
import { VictoryPie, VictoryLabel, VictoryContainer } from 'victory';
import PropTypes from 'prop-types';
import '../index.css';

function SurfaceChart(props) {
  const roundedDistance = parseFloat((props.totalDistance).toFixed(3));
  return (
    <VictoryContainer width={400} height={400}>
      <VictoryPie
        standalone={false}
        colorScale={["rgb(95,188,228)", "rgb(73,161,105)", "rgb(228,212,121)", "rgb(220,114,48)"]}
        data={props.data}
        innerRadius={100}
        style={{ labels: { fill: "#111111", fontSize: 14, padding: 2, fontFamily: "'Montserrat', sans-serif" } }}
      />
      <VictoryLabel
        textAnchor="middle"
        verticalAnchor="middle"
        style={{ fontSize: 24, fontFamily: "'Montserrat', sans-serif" }}
        x={200} y={200}
        text={`${roundedDistance}\nmiles`}
      />
    </VictoryContainer>
  )
}

SurfaceChart.propTypes = {
  route: PropTypes.array,
  totalDistance: PropTypes.number
};

export default SurfaceChart;