import React from 'react';
import { SVG_SUCCESS } from '../../common/enums/svg';
import './Success.scss';

export const Success = ({ message }: { message?: string }) => {
  return (
    <article className="success">
      {SVG_SUCCESS}
      <h2>Done!</h2>
      {message ?
        <p className="attention">{message}</p> :
        <div />
      }
    </article>
  );
};
