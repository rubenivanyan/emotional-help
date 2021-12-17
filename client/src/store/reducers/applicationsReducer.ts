import { APPLICATIONS_FETCH_SUCCEEDED, SET_INFO } from '../actions';

const initState = {
  id: null,
  name: '',
  email: '',
  message: '',
  applicationInfo: '',
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
    case SET_INFO:
      console.log(action.payload);
      return { ...state, applicationInfo: action.payload };
    default:
      return state;
  }
};
