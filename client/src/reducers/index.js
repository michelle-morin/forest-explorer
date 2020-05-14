import routeReducer from './route-reducer';
import trailsReducer from './trails-reducer';
import { combineReducers } from 'redux';

const rootReducer = combineReducers({
  trailsAPIResponse: trailsReducer,
  mapInteractions: routeReducer
});

export default rootReducer;