import { BLOCK_TITLES } from '../../../common/enums/block-titles';
import { Block } from '../../Block/Block';
import React from 'react';
import './Info.scss';
import { useSelector } from 'react-redux';
import { RootState } from '../../../store/reducers/rootReducer';

export const Info = () => {
  const appInfo = useSelector((state: RootState) => state.applicationInfo);
  console.log('APP INFO', appInfo);
  return (
    <Block title={BLOCK_TITLES.INFORMATION} percentWidth={50}>
      <div className="application-info">
        Full name: {appInfo.applicationInfo.userName}
      </div>
      <div className="application-info">
        Email: {appInfo.applicationInfo.email}
      </div>
      <div className="application-info">
        Message: {appInfo.applicationInfo.message}
      </div>
    </Block>
  );
};
