import { AUTH_FETCH_SUCCEEDED } from '../actions';

const initState = {
  isLogged: false,
};

export const authReducer = (state = initState, action) => {
  console.log('action Auth', action);
  console.log('action type Auth', action.type);
  console.log('state Auth', state);
  switch (action.type) {
    case AUTH_FETCH_SUCCEEDED:
      const auth = action.payload.data;
      return {
        isLogged: auth,
      };
    default:
      return state;
  }
};
