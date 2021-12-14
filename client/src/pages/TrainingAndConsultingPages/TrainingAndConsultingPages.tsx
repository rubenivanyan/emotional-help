import { Block } from '../../components/Block/Block';
import React, { PropsWithChildren } from 'react';
import './TrainingAndConsultingPages.scss';
import {
  BLOCKS_TITLES,
  TRAINING_AND_CONSULTING_TEXT,
} from '../../common/enums';

const ParentComponent = ({ title, text, children }:
  PropsWithChildren<{ title: string, text: string }>) => {
  return (
    <section className={title + '-page-container'}>
      <Block title={title} percentWidth={100}>
        <p>{text}</p>
        {children}
      </Block>
    </section>
  );
};

export const TrainingPage = () => {
  return (
    <ParentComponent
      title={BLOCKS_TITLES.TRAINING}
      text={TRAINING_AND_CONSULTING_TEXT.TRAINING_TEXT}
    >

    </ParentComponent>
  );
};

export const ConsultingPage = () => {
  return (
    <ParentComponent
      title={BLOCKS_TITLES.CONSULTING}
      text={TRAINING_AND_CONSULTING_TEXT.CONSULTING_TEXT}
    >

    </ParentComponent>
  );
};

