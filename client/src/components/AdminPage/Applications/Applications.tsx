import { BLOCKS_TITLES } from '../../../common/enums';
import { Block } from '../../Block/Block';
import React, { PropsWithChildren } from 'react';
import './Applications.scss';

export const Applications = ({ children }: PropsWithChildren<{}>) => {
  return (
    <Block title={BLOCKS_TITLES.APPLICATIONS} percentWidth={25}>
      {children}
    </Block>
  );
};
