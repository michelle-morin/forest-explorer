import routeReducer from './../../reducers/route-reducer';

describe('routeReducer', () => {
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


});
