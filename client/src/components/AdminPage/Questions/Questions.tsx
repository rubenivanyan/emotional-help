import { BLOCKS_TITLES } from '../../../common/enums';
import { Block } from '../../Block/Block';
import React, { useEffect, useState } from 'react';
import './Questions.scss';
import { useParams } from 'react-router-dom';
import { QuestionCard } from '../QuestionCard/QuestionCard';
import axios from 'axios';
import { AddQuestionCard } from '../QuestionCard/AddQuestionCard';

export const Questions = () => {
  const { id } = useParams();
  const [data, setData] = useState([]);
  useEffect(() => {
    axios
      .get(
        `https://emotionalhelptest.azurewebsites.net/api/Test/${id}/with-questions`,
      )
      .then((response) => {
        setData(response.data.questions);
      })
      .catch((error) => {
        console.log(error);
      });
  }, []);
  return (
    <Block title={BLOCKS_TITLES.QUESTIONS} percentWidth={60}>
      <div className="questions-wrapper">
        {data.map((question, index) => {
          return <QuestionCard key={question.id} question={question} />;
        })}
        <AddQuestionCard />
      </div>
    </Block>
  );
};
