import React from 'react';
import './UserPanel.scss';
import { Auth } from 'api';
import { BUTTON_TYPES } from 'enums';
import { Button } from 'components';


export const UserPanel = ({ isAdmin }: { isAdmin: boolean }) => {
  return (
    <div className="user-panel">
      {isAdmin && <a className="button" href="/admin">ADMIN</a>}
      <a className="button" href="/personal-page">PROFILE</a>
      <Button
        title={'logout'}
        type={BUTTON_TYPES.RED}
        onClick={() => Auth.logout()}
      />
    </div>
  );
};
