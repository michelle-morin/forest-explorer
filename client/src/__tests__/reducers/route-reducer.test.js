import routeReducer from './../../reducers/route-reducer';
import * as c from './../../actions/ActionTypes';

describe('routeReducer', () => {
  let action;

  const initialState = {
    selectedTarget: null,
    selectedTrailId: null,
    verifiedRoute: [],
    routeDistance: 0
  };

  const selectedState = {
    selectedTarget: 'test',
    selectedTrailId: 1,
    verifiedRoute: [],
    routeDistance: 0
  };

  it('should successfully return the default state if no action type is passed to the reducer', () => {
    expect(routeReducer(initialState, { type: null })).toEqual({
      selectedTarget: null,
      selectedTrailId: null,
      verifiedRoute: [],
      routeDistance: 0
    });
  });

  test('clicking a trail segment should change selectedTrailId to the selected trail id and selectedTarget to the selected geojson layer', () => {
    action = {
      type: c.CHANGE_SELECTED_TRAIL,
      selectedTarget: 'test',
      selectedTrailId: 1
    };
    expect(routeReducer(initialState, action)).toEqual({
      selectedTarget: 'test',
      selectedTrailId: 1,
      verifiedRoute: [],
      routeDistance: 0
    });
  });

  test('adding a trail segment to a route should change the verifiedRoute to include the segment and update the total route distance', () => {
    action = {
      type: c.ADD_SEGMENT_TO_ROUTE,
      selectedTrailId: 1,
      trailDistance: 0.546
    };
    expect(routeReducer(selectedState, action)).toEqual({
      selectedTarget: 'test',
      selectedTrailId: 1,
      verifiedRoute: [1],
      routeDistance: 0.546
    });
  });
});
