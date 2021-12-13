import React, { PropsWithChildren } from 'react';
import './Block.scss';

export const Block = ({ title, percentWidth, children }:
  PropsWithChildren<{ title: string, percentWidth: number }>) => {
  return (
    <section className="block-wrapper" style={{ width: percentWidth + '%' }}>
      <h2>{title}</h2>
      {children}
    </section>
  );
};
