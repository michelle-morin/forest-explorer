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
    default:
      return state;
  }
};