import * as c from './../actions/ActionTypes';

const initialState = {
  selectedTarget: null,
  selectedTrailId: null,
  verifiedRoute: [],
  routeDistance: 0
};

export default (state = initialState, action) => {
  switch (action.type) {
    case c.CHANGE_SELECTED_TRAIL:
      return Object.assign({}, state, {
        selectedTarget: action.selectedTarget,
        selectedTrailId: action.selectedTrailId
      });
    case c.ADD_SEGMENT_TO_ROUTE:
      const existingRoute = state.verifiedRoute;
      const newRoute = existingRoute.concat(action.selectedTrailId);
      const newDistance = state.routeDistance + action.trailDistance;
      return Object.assign({}, state, {
        verifiedRoute: newRoute,
        routeDistance: newDistance
      });
    default:
      return state;
  }
};