import React from 'react';
import './UserPanel.scss';
import { Auth } from 'api';
import { BUTTON_TYPES } from 'enums';
import { Button } from 'components';


export const UserPanel = () => {
  return (
    <div className="user-panel">
      <a className="button" href="/personal-page">PROFILE</a>
      <Button
        title={'logout'}
        type={BUTTON_TYPES.RED}
        onClick={() => Auth.logout()}
      />
    </div>
  );
};
