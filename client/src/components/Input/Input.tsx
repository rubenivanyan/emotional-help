import { INPUT_TYPES } from '../../common/enums/input-types';
import React from 'react';
import './Input.scss';
import { InputComponent } from '../../common/types/input-component';

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
