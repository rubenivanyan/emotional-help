import { all } from 'redux-saga/effects';
import { applicationsFetchRequestedWatcherSaga } from './saga-applications';
import {
  testsFetchRequestedWatcherSaga,
  testsPutRequestedWatcherSaga,
  testsDeleteRequestedWatcherSaga,
} from './saga-tests';

export function* rootSaga() {
  yield all([
    applicationsFetchRequestedWatcherSaga(),
    testsFetchRequestedWatcherSaga(),
    testsPutRequestedWatcherSaga(),
    testsDeleteRequestedWatcherSaga(),
  ]);
}
