import { Block } from '../../components/Block/Block';
import React, { PropsWithChildren, useState } from 'react';
import './TrainingAndConsultingPages.scss';
import { BLOCK_TITLES } from '../../common/block-titles';
import { TRAINING_AND_CONSULTING_TEXT } from '../../common/texts';
import { Button } from '../../components/Button/Button';
import { BUTTON_TYPES } from '../../common/button-types';
import { Input } from '../../components/Input/Input';

const ParentComponent = ({ title, text, children }:
  PropsWithChildren<{ title: string, text: string }>) => {
  const [success, setSuccess] = useState(false);
  const [error, setError] = useState(false);
  const [isSubmiting, setIsSubmiting] = useState(false);

  const handleSubmit = (event: React.FormEvent<HTMLElement>) => {
    setIsSubmiting(true);
    event.preventDefault();
    const random = Math.round(Math.random());
    setTimeout(() => {
      random ? setSuccess(true) : setError(true);
      setIsSubmiting(false);
    }, 2000);
  };

  return (
    <section className={title + '-page-container'}>
      <Block title={title} percentWidth={100}>
        <div className={title + '-page-inner'}>
          <p>{text}</p>
          {success ?
            <Success /> :
            error ?
              <>
                <Error />
                <Button title={'retry'}
                  type={BUTTON_TYPES.DEFAULT}
                  onClick={() => setError(false)}
                />
              </> :
              <form onSubmit={(e) => handleSubmit(e)}>
                {children}
                <Button
                  title={'submit'}
                  type={BUTTON_TYPES.DEFAULT}
                  submiting={isSubmiting}
                />
              </form>
          }
        </div>
      </Block>
    </section>
  );
};

const Success = () => {
  return (
    <>
      <h2>Done!</h2>
      <p className="attention">We will contact you as soon as possible</p>
    </>
  );
};

const Error = () => {
  return (
    <h3>Something went wrong...</h3>
  );
};

export const TrainingPage = () => {
  return (
    <ParentComponent
      title={BLOCK_TITLES.TRAINING}
      text={TRAINING_AND_CONSULTING_TEXT.TRAINING_TEXT}
    >
      <Input label={'Name'} isRequired={true} />
      <Input label={'E-mail'} />
    </ParentComponent>
  );
};

export const ConsultingPage = () => {
  return (
    <ParentComponent
      title={BLOCK_TITLES.CONSULTING}
      text={TRAINING_AND_CONSULTING_TEXT.CONSULTING_TEXT}
    >
      <Input label={'Name'} />
      <Input label={'E-mail'} />
      <Input label={'Convenient day'} />
    </ParentComponent>
  );
};

