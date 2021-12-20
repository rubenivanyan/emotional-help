import { BUTTON_TYPES } from '../../common/enums/button-types';
import React from 'react';
import './Button.scss';

export const Button = ({ title, type, submitting, onClick }:
  { title: string, type: BUTTON_TYPES, submitting?: boolean, onClick?}) => {
  return <button
    className={'button ' + type + (submitting ? ' submit ' : '')}
    onClick={onClick}
  >
    {title}
  </button>;
};
