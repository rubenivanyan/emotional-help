import React from 'react';
import './Registration.scss';

export const Registration: React.FC = () => {
  return (
    <div className="reg-buttons-container">
      <a className="sign-in" href="/sign-in">Sign in</a>
      <a className="sign-up" href="/sign-up">Sign up</a>
    </div>
  );
};
