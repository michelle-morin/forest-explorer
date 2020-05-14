import trailsReducer from './../../reducers/trails-reducer';
import * as c from './../../actions/ActionTypes';

describe('trailsReducer', () => {
  let action;

  const initialState = {
    isLoading: false,
    trails: [],
    error: null
  };

  it('should successfully return the default state if no action type is passed to the reducer', () => {
    expect(trailsReducer(initialState, { type: null })).toEqual({
      isLoading: false,
      trails: [],
      error: null
    });
  });

  test('requesting trails should successfully change isLoading from false to true', () => {
    action = {
      type: c.REQUEST_TRAILS
    };
    expect(trailsReducer(initialState, action)).toEqual({
      isLoading: true,
      trails: [],
      error: null
    });
  });

});