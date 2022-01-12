import { call, put, takeLatest } from 'redux-saga/effects';
import {
  AUTH_FETCH_REQUESTED,
  AUTH_FETCH_SUCCEEDED,
} from './actions';
import { Auth } from 'api';

export function* fetchAuth() {
  try {
    const { isLogged, isAdmin } = yield call(Auth.isLogged);
    console.log('saga :' + isLogged);
    yield put({
      type: AUTH_FETCH_SUCCEEDED,
      payload: {
        isLogged: isLogged,
        isAdmin: isAdmin,
      },
    });
  } catch (e) {
    alert('/api/User/is-authenticated: ' + e);
  }
}

export function* authFetchRequestedWatcherSaga() {
  yield takeLatest(AUTH_FETCH_REQUESTED, fetchAuth);
}
