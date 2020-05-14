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