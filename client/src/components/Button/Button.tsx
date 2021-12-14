import { BUTTON_TYPES } from '../../common/button-types';
import React from 'react';
import './Button.scss';

export const Button = ({ title, type, submiting, onClick }:
  { title: string, type: BUTTON_TYPES, submiting?: boolean, onClick?}) => {
  return <button
    className={'button ' + type + (submiting ? ' submit ' : '')}
    onClick={onClick}
  >
    {title}
  </button>;
};
