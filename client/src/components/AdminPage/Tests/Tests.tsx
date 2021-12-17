import { BLOCK_TITLES } from '../../../common/enums/block-titles';
import { Block } from '../../Block/Block';
import React, { useEffect, useState } from 'react';
import './Tests.scss';
import { TestCard } from '../TestCard/TestCard';
import axios from 'axios';
import { AddTestCard } from '../TestCard/AddTestCard';

export const Tests = () => {
  const [data, setData] = useState([]);
  useEffect(() => {
    axios
      .get('https://emotionalhelptest.azurewebsites.net/api/Test/')
      .then((response) => {
        console.log(response.data);
        setData(response.data);
      })
      .catch((error) => {
        console.log(error);
      });
  }, []);
  return (
    <Block title={BLOCK_TITLES.TESTS} percentWidth={60}>
      <div className="tests-wrapper">
        {data.map((test, index) => {
          return <TestCard key={test.id} test={test} />;
        })}
        <AddTestCard />
      </div>
    </Block>
  );
};
