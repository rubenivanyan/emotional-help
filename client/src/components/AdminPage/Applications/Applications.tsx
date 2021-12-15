import React, { useEffect } from 'react';
import { Outlet } from 'react-router-dom';
import { useDispatch } from 'react-redux';
import { BLOCKS_TITLES } from '../../../common/enums';
import { Block } from '../../Block/Block';
import { Info } from '../Info/Info';
import { appFetchRequest } from '../../../store/actions';
import './Applications.scss';

export const Applications = () => {
  const dispatch = useDispatch();
  useEffect(() => {
    dispatch(appFetchRequest());
  }, []);

  return (
    <>
      <Block title={BLOCKS_TITLES.APPLICATIONS} percentWidth={25}>
        <Outlet />
      </Block>
      <Info />
    </>
  );
};
