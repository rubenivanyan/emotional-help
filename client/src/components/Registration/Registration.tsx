import React from 'react';
import './Registration.scss';

export const Registration: React.FC = () => {
  return (
    <div className="reg-buttons-container">
      <button className="sign-in">Sign in</button>
      <button className="sign-up">Sign up</button>
    </div>
  );
};
