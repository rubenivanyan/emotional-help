import { combineReducers } from 'redux';
import { applicationsReducer } from './applicationsReducer';
import { testsReducer } from './testsReducer';

export const rootReducer = combineReducers({
  applications: applicationsReducer,
  applicationInfo: applicationsReducer,
  tests: testsReducer,
});

export type RootState = ReturnType<typeof rootReducer>;
