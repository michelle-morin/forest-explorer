import React from 'react';
import { VictoryPie, VictoryLabel } from 'victory';
import PropTypes from 'prop-types';

function SurfaceChart(props) {

  return (
    <React.Fragment>
      <VictoryPie
        colorScale={["#008f68", "#EFBB35", "#6DB65B", "#4AAE9B", "#EF6D35"]}
        data={props.data}
        width={400} height={400}
        innerRadius={70}
      />
      <VictoryLabel
        textAnchor="middle"
        style={{ fontSize: 20 }}
        x={200} y={200}
        text={props.totalDistance}
      />
    </React.Fragment>
  )
}

SurfaceChart.propTypes = {
  route: PropTypes.array,
  totalDistance: PropTypes.number
};

export default SurfaceChart;