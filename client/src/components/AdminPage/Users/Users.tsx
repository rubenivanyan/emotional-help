import { BLOCKS_TITLES } from '../../../common/enums';
import { Block } from '../../Block/Block';
import React from 'react';
import './Users.scss';
import { Outlet } from 'react-router-dom';

export const Users = () => {
  return (
    <Block title={BLOCKS_TITLES.USERS} percentWidth={60}>
      <Outlet />
    </Block>
  );
};
