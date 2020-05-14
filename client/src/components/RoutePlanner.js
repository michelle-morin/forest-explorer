import React from 'react';
import { connect } from 'react-redux';
import { getAllTrailsFromApi } from './../actions';

class RoutePlanner extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      clickedSegment: null,
      verifiedRoute: [],
      routeDistance: 0
    }
  }

  componentDidMount() {
    const { dispatch } = this.props;
    dispatch(getAllTrailsFromApi());
  }

  render() {
    const { isLoading, trails, error } = this.props;
    if (error) {
      return <React.Fragment>Error: {error.message}</React.Fragment>
    } else if (isLoading) {
      return <React.Fragment>Loading...</React.Fragment>
    } else {
      return (
        <React.Fragment>
          <ol>
          {trails.map((trail) => <li key={trail.trailId}>{trail.name}</li>)}
          </ol>
        </React.Fragment>
      );
    }
  }
}

const mapStateToProps = state => {
  return {
    isLoading: state.isLoading,
    trails: state.trails,
    error: state.error
  }
}

export default connect(mapStateToProps)(RoutePlanner);