import { combineReducers } from 'redux';
import { applicationsReducer } from './applicationsReducer';
import { questionsReducer } from './questionsReducer';
import { testsReducer } from './testsReducer';

export const rootReducer = combineReducers({
  applications: applicationsReducer,
  applicationInfo: applicationsReducer,
  tests: testsReducer,
  questions: questionsReducer,
});

export type RootState = ReturnType<typeof rootReducer>;
