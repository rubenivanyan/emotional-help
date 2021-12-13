import React, { PropsWithChildren } from 'react';
import './List.scss';

export const List = ({ children }: PropsWithChildren<{}>) => {
  return (
    <ul className="list-wrapper">
      {children}
    </ul>
  );
};
