import { BLOCKS_TITLES } from '../../../common/enums';
import { Block } from '../../Block/Block';
import React, { useEffect, useState } from 'react';
import './Questions.scss';
import { Outlet, useParams } from 'react-router-dom';
import { QuestionCard } from '../QuestionCard/QuestionCard';
import axios from 'axios';

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
      {data.map((question, index) => {
        return <QuestionCard key={question.id} question={question} />;
      })}

      <Outlet />
    </Block>
  );
};
