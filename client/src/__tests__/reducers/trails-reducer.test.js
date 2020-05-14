import trailsReducer from '../../reducers/trails-reducer';

describe('trailsReducer', () => {
  const initialState = {
    isLoading: false,
    trails: [],
    error: null
  };

  it('should successfully return the default state if no action type is passed to the reducer', () => {
    expect(trailsReducer(initialState, { type: null })).toEqual(
      {
        isLoading: false,
        trails: [],
        error: null
      }
    );
  });

});