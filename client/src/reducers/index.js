import routeReducer from './route-reducer';
import trailsReducer from './trails-reducer';
import { combineReducers } from 'redux';

const rootReducer = combineReducers({
  trailsApiResponse: trailsReducer,
  mapInteractions: routeReducer
});

export default rootReducer;