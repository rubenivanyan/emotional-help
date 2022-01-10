import { AUTH_FETCH_SUCCEEDED } from '../actions';

const initState = {
  isLogged: 'danone',
};

export const authReducer = (state = initState, action) => {
  console.log('action ', action);
  console.log('action type ', action.type);
  console.log('state ', state);
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
