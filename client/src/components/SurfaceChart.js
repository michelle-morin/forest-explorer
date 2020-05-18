import React from 'react';
import { VictoryPie, VictoryLabel } from 'victory';
import PropTypes from 'prop-types';

function SurfaceChart(props) {
  const roundedDistance = parseFloat((props.totalDistance).toFixed(3));
  return (
    <svg width={500} height={500}>
      <VictoryPie
        standalone={false}
        colorScale={["#008f68", "#EFBB35", "#6DB65B", "#4AAE9B", "#EF6D35"]}
        data={props.data}
        width={500}
        height={500}
        innerRadius={125}
      />
      <VictoryLabel
        textAnchor="middle"
        verticalAnchor="middle"
        style={{ fontSize: 20 }}
        x={250} y={250}
        text={`${roundedDistance} miles`}
      />
    </svg>
  )
}

SurfaceChart.propTypes = {
  route: PropTypes.array,
  totalDistance: PropTypes.number
};

export default SurfaceChart;