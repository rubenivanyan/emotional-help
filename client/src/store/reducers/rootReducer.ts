import { combineReducers } from 'redux';
import { applicationsReducer } from './applicationsReducer';
import { questionsReducer } from './questionsReducer';
import { testsReducer } from './testsReducer';
import { authReducer } from './authReducer';

export const rootReducer = combineReducers({
  applications: applicationsReducer,
  applicationInfo: applicationsReducer,
  tests: testsReducer,
  questions: questionsReducer,
  auth: authReducer,
});

export type RootState = ReturnType<typeof rootReducer>;
