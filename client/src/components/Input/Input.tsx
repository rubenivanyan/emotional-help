import React from 'react';
import './Input.scss';

export const Input = ({ label, onChange }:
  { label: string, onChange?}) => {
  return (
    <div className="input-container">
      <label>{label}</label>
      <input type="input"
        placeholder={'Type ' + label + ' here'}
        required
        onChange={onChange}
      ></input>
    </div>
  );
};
