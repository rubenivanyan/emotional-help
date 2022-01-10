import { TESTS_FETCH_SUCCEEDED } from '../actions';

const initState = {
  tests: [],
};

export const testsReducer = (state = initState, action) => {
  console.log('action ', action);
  console.log('action type ', action.type);
  console.log('state ', state);
  switch (action.type) {
    case TESTS_FETCH_SUCCEEDED: {
      const tests = action.payload.data;
      console.log('TESTS', tests);
      return {
        ...state,
        tests,
      };
    }
    default:
      return state;
  }
};
