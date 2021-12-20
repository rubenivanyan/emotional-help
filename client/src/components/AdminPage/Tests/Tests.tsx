import { BLOCK_TITLES } from '../../../common/enums/block-titles';
import { Block } from '../../Block/Block';
import React, { useEffect } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import './Tests.scss';
import { TestCard } from '../TestCard/TestCard';
import { AddTestCard } from '../TestCard/AddTestCard';
import { testsFetchRequest } from '../../../store/actions';
import { RootState } from '../../../store/reducers/rootReducer';

export const Tests = () => {
  const dispatch = useDispatch();
  const tests = useSelector((state: RootState) => state.tests.tests);
  console.log('STATE', tests);

  useEffect(() => {
    dispatch(testsFetchRequest());
    console.log('STATE', tests);
  }, []);
  return (
    <Block title={BLOCK_TITLES.TESTS} percentWidth={60}>
      <div className="tests-wrapper">
        {tests.map((test, index) => {
          return <TestCard key={test.id} test={test} />;
        })}
        <AddTestCard />
      </div>
    </Block>
  );
};
