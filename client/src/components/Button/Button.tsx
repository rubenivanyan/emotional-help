import { BUTTON_TYPES } from '../../common/button-types';
import React from 'react';
import './Button.scss';

export const Button = ({ title, type }:
  { title: string, type: BUTTON_TYPES }) => {
  return <button className={'button ' + type}>{title}</button>;
};
