import './UserPanel.scss';
import React from 'react';
import { Button } from '../../components/Button/Button';
import { BUTTON_TYPES } from '../../common/enums/button-types';
import { Auth } from '../../api/auth';

export const UserPanel = () => {
  return (
    <div>
      <a className="button" href="/profile">PROFILE</a>
      <Button
        title={'logout'}
        type={BUTTON_TYPES.RED}
        onClick={() => Auth.logout()}
      />
    </div>
  );
};
