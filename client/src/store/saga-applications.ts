import { call, put, takeLatest } from 'redux-saga/effects';
import {
  APPLICATIONS_FETCH_REQUESTED,
  APPLICATIONS_FETCH_SUCCEEDED,
  APPLICATIONS_FETCH_FAILED,
} from './actions';
import { getApplications } from '../api/fetch/applications';

export function* fetchApplications(action) {
  try {
    const episode = yield call(
      getApplications,
      'api/TrainingApplication',
    );
    yield put({
      type: APPLICATIONS_FETCH_SUCCEEDED,
      payload: {
        data: episode,
      },
    });
  } catch (e) {
    yield put({
      type: APPLICATIONS_FETCH_FAILED,
      payload: { message: e.message },
    });
  }
}

export function* applicationsFetchRequestedWatcherSaga() {
  yield takeLatest(APPLICATIONS_FETCH_REQUESTED, fetchApplications);
}
