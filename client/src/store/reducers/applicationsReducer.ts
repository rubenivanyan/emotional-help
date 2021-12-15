import { APPLICATIONS_FETCH_SUCCEEDED } from '../actions';

const initState = {
  id: null,
  name: '',
  email: '',
  message: '',
};

export const applicationsReducer = (state = initState, action) => {
  switch (action.type) {
    case APPLICATIONS_FETCH_SUCCEEDED: {
      const applications = action.payload.data;
      return {
        ...state,
        applications,
      };
    }
    default:
      return state;
  }
};
