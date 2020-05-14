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

export const getAllTrailsFromApi = () => {
  return (dispatch) => {
    dispatch(requestTrails);
    return fetch("http://localhost:5000/api/Trails")
      .then(response => response.json())
      .then((jsonifiedResponse) => {
        dispatch(getTrailsSuccess(jsonifiedResponse));
      })
      .catch((error) => {
        dispatch(getTrailsFailure(error));
      });
  }
};

export const changeSelectedTrail = (target, id) => ({
  type: c.CHANGE_SELECTED_TRAIL,
  selectedTarget: target,
  selectedTrailId: id
});

export const addSegmentToRoute = (target, id, distance) => ({
  type: c.ADD_SEGMENT_TO_ROUTE,
  selectedTarget: target,
  selectedTrailId: id,
  trailDistance: distance
});