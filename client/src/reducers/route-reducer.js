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
    default:
      return state;
  }
};