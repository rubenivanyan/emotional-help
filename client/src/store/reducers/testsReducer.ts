import { TESTS_FETCH_SUCCEEDED } from '../actions';

const initState = {
  tests: [],
};

export const testsReducer = (state = initState, action) => {
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
