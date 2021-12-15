import { BLOCKS_TITLES } from '../../../common/enums';
import { Block } from '../../Block/Block';
import React from 'react';
import './Info.scss';

export const Info = () => {
  return (
    <Block title={BLOCKS_TITLES.INFORMATION} percentWidth={50}>
      <div className="application-info">Full name: {null}</div>
      <div className="application-info">Email: {null}</div>
      <div className="application-info">Question: {null}</div>
    </Block>
  );
};
