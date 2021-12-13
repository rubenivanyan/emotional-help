import React, { PropsWithChildren } from 'react';
import './Main.scss';

export const Main = ({ children }: PropsWithChildren<{}>) => {
  return (
    <main className="main-wrapper">
      {children}
    </main>
  );
};
