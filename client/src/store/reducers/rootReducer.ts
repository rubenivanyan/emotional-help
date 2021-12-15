import { combineReducers } from 'redux';
import { applicationsReducer } from './applicationsReducer';

export const rootReducer = combineReducers({
  applications: applicationsReducer,
});

export type RootState = ReturnType<typeof rootReducer>;
