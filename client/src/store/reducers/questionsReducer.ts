import { QUESTIONS_FETCH_SUCCEEDED } from '../actions';

const initState = {
  questions: [],
};

export const questionsReducer = (state = initState, action) => {
  switch (action.type) {
    case QUESTIONS_FETCH_SUCCEEDED: {
      const questions = action.payload.data;
      console.log('TESTS', questions);
      return {
        ...state,
        questions,
      };
    }
    default:
      return state;
  }
};
