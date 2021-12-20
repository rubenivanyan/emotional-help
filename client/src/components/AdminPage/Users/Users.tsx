import { BLOCK_TITLES } from '../../../common/enums/block-titles';
import { Block } from '../../Block/Block';
import React from 'react';
import './Users.scss';
import { Outlet } from 'react-router-dom';

export const Users = () => {
  return (
    <Block title={BLOCK_TITLES.USERS} percentWidth={60}>
      <Outlet />
    </Block>
  );
};
