import * as c from './ActionTypes';

export const requestTrails = () => ({
  type: c.REQUEST_TRAILS
});

export const getTrailsSuccess = (trails) => ({
  type: c.GET_TRAILS_SUCCESS,
  trails
});

export const getTrailsFailure = (error) => ({
  type: c.GET_TRAILS_FAILURE,
  error
});