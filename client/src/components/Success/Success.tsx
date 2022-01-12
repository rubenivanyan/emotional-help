import React from 'react';
import './Success.scss';
import { SVG_SUCCESS } from 'enums';

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
