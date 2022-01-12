import React from 'react';
import './AuthComponent.scss';

export const AuthComponent = () => {
  return (
    <>
      <p className="auth-message">
        {
          `Only authenticated users
        can send application to ours specialist`
        }
      </p>
      <div className="auth-buttons-group">
        <a className="button" href="/sign-in">SIGN IN</a>
        <a className="button" href="/sign-up">SIGN UP</a>
      </div>
    </>
  );
};
