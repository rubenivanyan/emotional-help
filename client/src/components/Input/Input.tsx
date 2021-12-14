import React from 'react';
import './Input.scss';

export const Input = ({ label }: { label: string }) => {
  return (
    <div className="input-container">
      <label>{label}</label>
      <input type="input" placeholder={'Type ' + label + ' here'}></input>
    </div>
  );
};
