import React from 'react';
import './Input.scss';
import { INPUT_TYPES } from 'enums';
import { InputComponent } from 'types';

export const Input = ({
  label,
  onChange,
  value,
  type = INPUT_TYPES.TEXT,
  isRequired = false,
}: InputComponent) => {
  return (
    <div className="input-container">
      <label>{label}</label>
      <input
        placeholder={'Type ' + label + ' here'}
        onChange={onChange}
        value={value}
        type={type}
        required={isRequired}
      >
      </input>
    </div>
  );
};
