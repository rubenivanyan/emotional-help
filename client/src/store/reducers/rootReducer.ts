import { combineReducers } from 'redux';
import { applicationsReducer } from './applicationsReducer';
import { authReducer } from './authReducer';

export const rootReducer = combineReducers({
  applications: applicationsReducer,
  applicationInfo: applicationsReducer,
  user: authReducer,
});

export type RootState = ReturnType<typeof rootReducer>;
