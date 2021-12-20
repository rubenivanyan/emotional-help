export const APPLICATIONS_FETCH_REQUESTED = 'APPLICATIONS_FETCH_REQUESTED';
export const APPLICATIONS_FETCH_SUCCEEDED = 'APPLICATIONS_FETCH_SUCCEEDED';
export const APPLICATIONS_FETCH_FAILED = 'APPLICATIONS_FETCH_FAILED';
export const APPLICATIONS_FETCH_CANCEL = 'APPLICATIONS_FETCH_CANCEL';
export const AUTH_FETCH_SUCCEEDED = 'AUTH_FETCH_SUCCEEDED';
export const AUTH_FETCH_REQUESTED = 'AUTH_FETCH_REQUESTED';
export const SET_INFO = 'SET_INFO';

export function appFetchRequest() {
  return { type: APPLICATIONS_FETCH_REQUESTED, payload: {} };
}

export function authFetchRequest() {
  return { type: AUTH_FETCH_REQUESTED, payload: {} };
}

export function setInfo(value) {
  return { type: SET_INFO, payload: value };
}
