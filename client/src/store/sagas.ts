import { all } from 'redux-saga/effects';
import { applicationsFetchRequestedWatcherSaga } from './saga-applications';
import {
  questionsDeleteRequestedWatcherSaga,
  questionsFetchRequestedWatcherSaga,
  questionsPutRequestedWatcherSaga,
} from './saga-questions';
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
    questionsFetchRequestedWatcherSaga(),
    questionsPutRequestedWatcherSaga(),
    questionsDeleteRequestedWatcherSaga(),
  ]);
}
