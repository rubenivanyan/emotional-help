import { call, put, takeLatest } from 'redux-saga/effects';
import {
  QUESTIONS_FETCH_REQUESTED,
  QUESTIONS_FETCH_SUCCEEDED,
  QUESTIONS_FETCH_FAILED,
  QUESTIONS_PUT_REQUESTED,
  QUESTIONS_DELETE_REQUESTED,
} from './actions';
import {
  getQuestions,
  putQuestions,
  deleteQuestions,
} from '../components/AdminPage/api/questionCRUD';

export function* fetchQuestion(action) {
  try {
    const questions = yield call(getQuestions, action.payload.data);
    console.log('payload', questions);
    yield put({
      type: QUESTIONS_FETCH_SUCCEEDED,
      payload: {
        data: questions,
      },
    });
  } catch (e) {
    yield put({
      type: QUESTIONS_FETCH_FAILED,
      payload: { message: e.message },
    });
  }
}

export function* questionsFetchRequestedWatcherSaga() {
  yield takeLatest(QUESTIONS_FETCH_REQUESTED, fetchQuestion);
}

export function* putQuestion(action) {
  yield call(putQuestions, action.payload.data);
}

export function* questionsPutRequestedWatcherSaga() {
  yield takeLatest(QUESTIONS_PUT_REQUESTED, putQuestion);
}

export function* deleteQuestion(action) {
  yield call(deleteQuestions, action.payload.data);
}

export function* questionsDeleteRequestedWatcherSaga() {
  yield takeLatest(QUESTIONS_DELETE_REQUESTED, deleteQuestion);
}
