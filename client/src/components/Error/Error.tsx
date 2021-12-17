import React from 'react';
import { SVG_ERROR } from '../../common/enums/svg';
import './Error.scss';

export const Error = ({ error }: { error?: string }) => {
  return (
    <article className="error">
      {SVG_ERROR}
      <h3>Error!</h3>
      <p>{error ? error : 'Something went wrong...'}</p>
    </article>
  );
};
