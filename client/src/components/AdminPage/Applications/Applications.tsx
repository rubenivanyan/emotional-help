import { BLOCK_TITLES } from '../../../common/enums/block-titles';
import { Block } from '../../Block/Block';
import React, { PropsWithChildren } from 'react';
import './Applications.scss';

export const Applications = ({ children }: PropsWithChildren<{}>) => {
  return (
    <Block title={BLOCK_TITLES.APPLICATIONS} percentWidth={25}>
      {children}
    </Block>
  );
};
