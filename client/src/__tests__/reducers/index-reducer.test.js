import rootReducer from './../../reducers/index';
import * as c from './../../actions/ActionTypes';
import { createStore } from 'redux';
import trailsReducer from '../../reducers/trails-reducer';
import routeReducer from '../../reducers/route-reducer';

let store = createStore(rootReducer);

describe('rootReducer', () => {
  test('should return default state if no action type is recognized', () => {
    expect(rootReducer({}, { type: null })).toEqual({
      trailsAPIResponse: {
        isLoading: false,
        trails: [],
        error: null
      },
      mapInteractions: {
        selectedTarget: null,
        selectedTrailId: null,
        verifiedRoute: [],
        routeDistance: 0
      }
    });
  });

  test('that initial state of trailsReducer matches rootReducer', () => {
    expect(store.getState().trailsAPIResponse).toEqual(trailsReducer(undefined, { type: null }));
  });

  test('that initial state of routeReducer matches rootReducer', () => {
    expect(store.getState().mapInteractions).toEqual(routeReducer(undefined, { type: null }));
  });

  test('that routeReducer CHANGE_SELECTED_TRAIL action matches rootReducer', () => {
    const action = {
      type: c.CHANGE_SELECTED_TRAIL,
      selectedTarget: 'test',
      selectedTrailId: 1
    };
    store.dispatch(action);
    expect(store.getState().mapInteractions).toEqual(routeReducer(undefined, action));
  });

  test('that routeReducer ADD_SEGMENT_TO_ROUTE action matches rootReducer', () => {
    const action = {
      type: c.ADD_SEGMENT_TO_ROUTE,
      selectedTarget: 'test',
      selectedTrailId: 1,
      trailDistance: 0.7659
    };
    store.dispatch(action);
    expect(store.getState().mapInteractions).toEqual(routeReducer(undefined, action));
  });
});