import React from 'react';
import { VictoryPie, VictoryLabel, VictoryContainer } from 'victory';
import PropTypes from 'prop-types';

function SurfaceChart(props) {
  const roundedDistance = parseFloat((props.totalDistance).toFixed(3));
  return (
    <VictoryContainer width={400} height={400}>
      <VictoryPie
        standalone={false}
        colorScale={["#008f68", "#EFBB35", "#6DB65B", "#4AAE9B", "#EF6D35"]}
        data={props.data}
        width={400}
        height={400}
        innerRadius={80}
        style={{ labels: { fill: "#111111", fontSize: 18, padding: 4, fontFamily: "'Montserrat', sans-serif" } }}
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