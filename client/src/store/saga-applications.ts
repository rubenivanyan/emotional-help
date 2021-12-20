import { call, put, takeLatest } from 'redux-saga/effects';
import {
  TRAINING_APPS_FETCH_REQUESTED,
  TRAINING_APPS_FETCH_SUCCEEDED,
  TRAINING_APPS_FETCH_FAILED,
  TRAINING_APPS_PUT_REQUESTED,
  TRAINING_APPS_DELETE_REQUESTED,
} from './actions';
// eslint-disable-next-line
import {
  getTrainApps,
  putTrainApps,
  deleteTrainApps,
} from '../components/AdminPage/api/trainingAppsCRUD';

export function* fetchApplications(action) {
  try {
    const trainApps = yield call(getTrainApps, action.payload);
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

export function* putApplication(action) {
  yield call(putTrainApps, action.payload.data);
}

export function* applicationsPutRequestedWatcherSaga() {
  yield takeLatest(TRAINING_APPS_PUT_REQUESTED, putTrainApps);
}

export function* deleteApplication(action) {
  yield call(deleteTrainApps, action.payload.data);
}

export function* applicationsDeleteRequestedWatcherSaga() {
  yield takeLatest(TRAINING_APPS_DELETE_REQUESTED, deleteTrainApps);
}
