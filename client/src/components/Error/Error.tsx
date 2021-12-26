import React from 'react';
import './Error.scss';
import { SVG_ERROR } from 'enums';

export const Error = ({ error }: { error?: string }) => {
  return (
    <article className="error">
      {SVG_ERROR}
      <h3>Error!</h3>
      <p>{error ? error : 'Something went wrong...'}</p>
    </article>
  );
};
