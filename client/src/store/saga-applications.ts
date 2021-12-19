import { call, put, takeLatest } from 'redux-saga/effects';
import {
  TRAINING_APPS_FETCH_REQUESTED,
  TRAINING_APPS_FETCH_SUCCEEDED,
  TRAINING_APPS_FETCH_FAILED,
} from './actions';
// eslint-disable-next-line
import { getTrainingApplication } from '../components/AdminPage/api/trainingAppsCRUD';

export function* fetchApplications(action) {
  try {
    const trainApps = yield call(getTrainingApplication, action.payload);
    yield put({
      type: TRAINING_APPS_FETCH_SUCCEEDED,
      payload: {
        data: trainApps,
      },
    });
  } catch (e) {
    yield put({
      type: TRAINING_APPS_FETCH_FAILED,
      payload: { message: e.message },
    });
  }
}

export function* applicationsFetchRequestedWatcherSaga() {
  yield takeLatest(TRAINING_APPS_FETCH_REQUESTED, fetchApplications);
}
