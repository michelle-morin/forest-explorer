import * as c from './../actions/ActionTypes';

const initialState = {
  isLoading: false,
  trails: [],
  error: null
};

export default (state = initialState, action) => {
  switch (action.type) {
    case c.REQUEST_TRAILS:
      return Object.assign({}, state, {
        isLoading: true
      });
    case c.GET_TRAILS_SUCCESS:
      return Object.assign({}, state, {
        isLoading: false,
        trails: action.trails
      });
    case c.GET_TRAILS_FAILURE:
      return Object.assign({}, state, {
        isLoading: false,
        error: action.error
      });
    default:
      return state;
  }
};