export const TRAINING_APPS_FETCH_REQUESTED = 'TRAINING_APPS_FETCH_REQUESTED';
export const TRAINING_APPS_FETCH_SUCCEEDED = 'TRAINING_APPS_FETCH_SUCCEEDED';
export const TRAINING_APPS_FETCH_FAILED = 'TRAINING_APPS_FETCH_FAILED';
export const TRAINING_APPS_FETCH_CANCEL = 'TRAINING_APPS_FETCH_CANCEL';
export const TRAINING_APPS_PUT_REQUESTED = 'TRAINING_APPS_PUT_REQUESTED';
export const TRAINING_APPS_DELETE_REQUESTED = 'TRAINING_APPS_DELETE_REQUESTED';
export const SET_INFO = 'SET_INFO';

export const QUESTIONS_FETCH_REQUESTED = 'QUESTIONS_FETCH_REQUESTED';
export const QUESTIONS_FETCH_SUCCEEDED = 'QUESTIONS_FETCH_SUCCEEDED';
export const QUESTIONS_FETCH_FAILED = 'QUESTIONS_FETCH_FAILED';
export const QUESTIONS_PUT_REQUESTED = 'QUESTIONS_PUT_REQUESTED';
export const QUESTIONS_DELETE_REQUESTED = 'QUESTIONS_DELETE_REQUESTED';

export const TESTS_FETCH_REQUESTED = 'TESTS_FETCH_REQUESTED';
export const TESTS_FETCH_SUCCEEDED = 'TESTS_FETCH_SUCCEEDED';
export const TESTS_FETCH_FAILED = 'TESTS_FETCH_FAILED';
export const TESTS_PUT_REQUESTED = 'TESTS_PUT_REQUESTED';
export const TESTS_DELETE_REQUESTED = 'TESTS_DELETE_REQUESTED';

export function trainAppsFetchRequest() {
  return { type: TRAINING_APPS_FETCH_REQUESTED, payload: {} };
}

export function testsFetchRequest() {
  return { type: TESTS_FETCH_REQUESTED, payload: {} };
}
export function testsPutRequest(value) {
  return { type: TESTS_PUT_REQUESTED, payload: value };
}
export function testsDeleteRequest(value) {
  return { type: TESTS_DELETE_REQUESTED, payload: value };
}

export function questionsFetchRequest(value) {
  console.log(value);
  return { type: QUESTIONS_FETCH_REQUESTED, payload: value };
}
export function questionsPutRequest(value) {
  return { type: QUESTIONS_PUT_REQUESTED, payload: value };
}
export function questionsDeleteRequest(value) {
  return { type: QUESTIONS_DELETE_REQUESTED, payload: value };
}

export function setInfo(value) {
  return { type: SET_INFO, payload: value };
}
