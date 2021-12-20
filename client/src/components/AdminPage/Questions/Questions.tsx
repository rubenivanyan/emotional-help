import { BLOCK_TITLES } from '../../../common/enums/block-titles';
import { Block } from '../../Block/Block';
import React, { useEffect } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import './Questions.scss';
import { useParams } from 'react-router-dom';
import { QuestionCard } from '../QuestionCard/QuestionCard';
import { AddQuestionCard } from '../QuestionCard/AddQuestionCard';
import { RootState } from '../../../store/reducers/rootReducer';
import { questionsFetchRequest } from '../../../store/actions';

export const Questions = () => {
  const { id } = useParams();
  const dispatch = useDispatch();
  const questions = useSelector(
    (state: RootState) => state.questions.questions,
  );
  console.log('STATE', questions);

  useEffect(() => {
    dispatch(questionsFetchRequest(id));
    console.log('STATE', questions);
  }, []);
  return (
    <Block title={BLOCK_TITLES.QUESTIONS} percentWidth={60}>
      <div className="questions-wrapper">
        {questions.map((question, index) => {
          return <QuestionCard key={question.id} question={question} />;
        })}
        <AddQuestionCard />
      </div>
    </Block>
  );
};
