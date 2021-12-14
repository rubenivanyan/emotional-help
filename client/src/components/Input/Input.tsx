import React from 'react';
import './Input.scss';

export const Input = ({ label, isRequired }:
  { label: string, isRequired?: boolean }) => {
  return (
    <div className="input-container">
      <label>{label}</label>
      <input type="input"
        placeholder={'Type ' + label + ' here'}
        required
      ></input>
    </div>
  );
};
