import { all } from 'redux-saga/effects';
import { applicationsFetchRequestedWatcherSaga } from './saga-applications';

export function* rootSaga() {
  yield all([applicationsFetchRequestedWatcherSaga()]);
}
