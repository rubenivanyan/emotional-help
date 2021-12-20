import { all } from 'redux-saga/effects';
import {
  applicationsDeleteRequestedWatcherSaga,
  applicationsFetchRequestedWatcherSaga,
  applicationsPutRequestedWatcherSaga,
} from './saga-applications';
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
    applicationsPutRequestedWatcherSaga(),
    applicationsDeleteRequestedWatcherSaga(),
    testsFetchRequestedWatcherSaga(),
    testsPutRequestedWatcherSaga(),
    testsDeleteRequestedWatcherSaga(),
    questionsFetchRequestedWatcherSaga(),
    questionsPutRequestedWatcherSaga(),
    questionsDeleteRequestedWatcherSaga(),
  ]);
}
