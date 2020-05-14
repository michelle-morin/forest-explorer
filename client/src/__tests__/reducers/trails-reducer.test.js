import trailsReducer from './../../reducers/trails-reducer';
import * as c from './../../actions/ActionTypes';

describe('trailsReducer', () => {
  let action;

  const initialState = {
    isLoading: false,
    trails: [],
    error: null
  };

  const loadingState = {
    isLoading: true,
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

  test('successfully getting trails should change isLoading to false and update trails', () => {
    const trails = "test trail";
    action = {
      type: c.GET_TRAILS_SUCCESS,
      trails
    };
    expect(trailsReducer(loadingState, action)).toEqual({
      isLoading: false,
      trails: "test trail",
      error: null
    });
  });

});