import * as a from './../../actions';
import * as c from './../../actions/ActionTypes';

describe('trailsReducer actions', () => {
  test('requestTrails should create REQUEST_TRAILS action', () => {
    expect(a.requestTrails()).toEqual({
      type: c.REQUEST_TRAILS
    });
  });

  test('getTrailsSuccess should create GET_TRAILS_SUCCESS action', () => {
    const trails = "test trail";
    expect(a.getTrailsSuccess(trails)).toEqual({
      type: c.GET_TRAILS_SUCCESS,
      trails
    });
  });

  test('getTrailsFailure should create GET_TRAILS_FAILURE action', () => {
    const error = "test error";
    expect(a.getTrailsFailure(error)).toEqual({
      type: c.GET_TRAILS_FAILURE,
      error
    });
  });
});