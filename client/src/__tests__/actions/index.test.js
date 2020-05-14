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

  test('addSegmentToRoute should create ADD_SEGMENT_TO_ROUTE action', () => {
    const target = 'target';
    const id = 1;
    const distance = 0.356;
    expect(a.addSegmentToRoute(target, id, distance)).toEqual({
      type: c.ADD_SEGMENT_TO_ROUTE,
      selectedTarget: 'target',
      selectedTrailId: 1,
      trailDistance: 0.356
    });
  });

  test('changeSelectedTrail should create CHANGE_SELECTED_TRAIL action', () => {
    const target = 'test';
    const id = 3;
    expect(a.changeSelectedTrail(target, id)).toEqual({
      type: c.CHANGE_SELECTED_TRAIL,
      selectedTarget: 'test',
      selectedTrailId: 3
    });
  });
});