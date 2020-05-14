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


});
