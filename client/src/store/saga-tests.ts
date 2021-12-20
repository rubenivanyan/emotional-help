import { call, put, takeLatest } from 'redux-saga/effects';
import {
  TESTS_FETCH_REQUESTED,
  TESTS_FETCH_SUCCEEDED,
  TESTS_FETCH_FAILED,
  TESTS_PUT_REQUESTED,
  TESTS_DELETE_REQUESTED,
} from './actions';
import {
  getTests,
  putTests,
  deleteTests,
} from '../components/AdminPage/api/testCRUD';

export function* fetchTest(action) {
  try {
    const tests = yield call(getTests, action.payload.data);
    console.log('payload', tests);
    yield put({
      type: TESTS_FETCH_SUCCEEDED,
      payload: {
        data: tests,
      },
    });
  } catch (e) {
    yield put({
      type: TESTS_FETCH_FAILED,
      payload: { message: e.message },
    });
  }
}

export function* testsFetchRequestedWatcherSaga() {
  yield takeLatest(TESTS_FETCH_REQUESTED, fetchTest);
}

export function* putTest(action) {
  yield call(putTests, action.payload);
}

export function* testsPutRequestedWatcherSaga() {
  yield takeLatest(TESTS_PUT_REQUESTED, putTest);
}

export function* deleteTest(action) {
  yield call(deleteTests, action.payload);
}

export function* testsDeleteRequestedWatcherSaga() {
  yield takeLatest(TESTS_DELETE_REQUESTED, deleteTest);
}
