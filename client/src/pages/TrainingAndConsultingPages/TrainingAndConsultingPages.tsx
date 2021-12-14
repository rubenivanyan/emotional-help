import { Block } from '../../components/Block/Block';
import React, { PropsWithChildren } from 'react';
import './TrainingAndConsultingPages.scss';
import { BLOCK_TITLES } from '../../common/block-titles';
import { TRAINING_AND_CONSULTING_TEXT } from '../../common/texts';
import { Button } from '../../components/Button/Button';
import { BUTTON_TYPES } from '../../common/button-types';
import { Input } from '../../components/Input/Input';

const ParentComponent = ({ title, text, children }:
  PropsWithChildren<{ title: string, text: string }>) => {
  // const [firstValue, setFirstValue] = useState('');
  // const [secondValue, setSecondValue] = useState('');

  const handleSubmit = (event: React.FormEvent<HTMLElement>) => {
    event.preventDefault();
    console.log('trying submit data...');
  };

  return (
    <section className={title + '-page-container'}>
      <Block title={title} percentWidth={100}>
        <div className={title + '-page-inner'}>
          <p>{text}</p>
          <form onSubmit={(e) => handleSubmit(e)}>
            {children}
            <Button title={'submit'} type={BUTTON_TYPES.DEFAULT} />
          </form>
          <p className="attention">We will contact you as soon as possible</p>
        </div>
      </Block>
    </section>
  );
};

export const TrainingPage = () => {
  return (
    <ParentComponent
      title={BLOCK_TITLES.TRAINING}
      text={TRAINING_AND_CONSULTING_TEXT.TRAINING_TEXT}
    >
      <Input label={'E-mail'} />
      <Input label={'Name'} />
    </ParentComponent>
  );
};

export const ConsultingPage = () => {
  return (
    <ParentComponent
      title={BLOCK_TITLES.CONSULTING}
      text={TRAINING_AND_CONSULTING_TEXT.CONSULTING_TEXT}
    >

    </ParentComponent>
  );
};

