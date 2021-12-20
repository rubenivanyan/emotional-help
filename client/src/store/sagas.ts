import { all } from 'redux-saga/effects';
import { applicationsFetchRequestedWatcherSaga } from './saga-applications';
import { authFetchRequestedWatcherSaga } from './saga-auth';

export function* rootSaga() {
  yield all([
    applicationsFetchRequestedWatcherSaga(),
    authFetchRequestedWatcherSaga(),
  ]);
}
