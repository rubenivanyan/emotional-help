import { LocalStorage } from 'api';
import { AUTH_FETCH_SUCCEEDED } from '../actions';

const initState = {
  isLogged: LocalStorage.getItem('id') ? true : false,
  isAdmin: LocalStorage.getItem('isAdmin') ? true : false,
};

export const authReducer = (state = initState, action):
{ isLogged: boolean, isAdmin: boolean } => {
  console.log('action Auth', action);
  console.log('action type Auth', action.type);
  console.log('state Auth', state);
  switch (action.type) {
    case AUTH_FETCH_SUCCEEDED:
      const auth = action.payload.isLogged;
      const role = action.payload.isAdmin;
      return {
        isLogged: auth,
        isAdmin: role,
      };
    default:
      return state;
  }
};
