import './ParentComponent.scss';
import React, { PropsWithChildren } from 'react';
import { Block } from '../../../components/Block/Block';

export const ParentComponent = ({ title, text, children }:
  PropsWithChildren<{ title: string, text: string }>) => {
  return (
    <section className={title + '-page-container'}>
      <Block title={title} percentWidth={100}>
        <div className={title + '-page-inner'}>
          <p>{text}</p>
          {children}
        </div>
      </Block>
    </section>
  );
};
