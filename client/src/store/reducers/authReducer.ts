import { AUTH_FETCH_SUCCEEDED } from '../actions';

const initState = {
  isLogged: false,
};

export const authReducer = (state = initState, action) => {
  switch (action.type) {
    case AUTH_FETCH_SUCCEEDED: {
      const auth = action.payload.data;
      return {
        ...state,
        auth,
      };
    }
    default:
      return state;
  }
};
