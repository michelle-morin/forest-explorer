import React from 'react';
import { VictoryPie, VictoryLabel, VictoryContainer } from 'victory';
import PropTypes from 'prop-types';

function SurfaceChart(props) {
  const roundedDistance = parseFloat((props.totalDistance).toFixed(3));
  return (
    <VictoryContainer width={400} height={400}>
      <VictoryPie
        standalone={false}
        colorScale={["rgb(238,193,175)", "rgb(201,221,188)", "rgb(146,169,219)", "rgb(213,215,232)"]}
        data={props.data}
        width={300}
        height={300}
        innerRadius={60}
        style={{ labels: { fill: "#111111", fontSize: 18, padding: 4, fontFamily: "'Montserrat', sans-serif" } }}
      />
      <VictoryLabel
        textAnchor="middle"
        verticalAnchor="middle"
        style={{ fontSize: 24, fontFamily: "'Montserrat', sans-serif" }}
        x={150} y={150}
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