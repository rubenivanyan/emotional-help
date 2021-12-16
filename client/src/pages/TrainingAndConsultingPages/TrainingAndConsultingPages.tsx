import { Block } from '../../components/Block/Block';
import React, { PropsWithChildren, useEffect, useState } from 'react';
import './TrainingAndConsultingPages.scss';
import { BLOCK_TITLES } from '../../common/enums/block-titles';
import { TRAINING_AND_CONSULTING_TEXT } from '../../common/enums/texts';
import { Button } from '../../components/Button/Button';
import { BUTTON_TYPES } from '../../common/enums/button-types';
import { Input } from '../../components/Input/Input';
import { apiFetchPost, apiFetchGet } from '../../api/fetch';
import {
  ConsultingApplication,
} from '../../common/types/consulting-application';
import { Training } from '../../common/types/training';
import { TrainingApplication } from '../../common/types/training-application';
import { TrainingComponent } from '../../components/Training/Training';
import { mockedTrainings } from '../../common/mocks/trainings';
import { Error } from '../../components/Error/Error';
import { Success } from '../../components/Success/Success';

const ParentComponent = ({ title, text, children }:
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


export const TrainingPage = () => {
  const [success, setSuccess] = useState(false);
  const [error, setError] = useState(false);

  const [isSubmitting, setIsSubmitting] = useState(false);

  const [userName, setUserName] = useState('');
  const [email, setEmail] = useState('');
  const [training, setTraining] = useState<Training | null>(null);
  const [trainings, setTrainings] = useState<Training[]>(mockedTrainings);
  const [counter, setCounter] = useState(0);
  const [isLoading, setIsLoading] = useState(true);

  useEffect(() => {
    apiFetchGet('/api/training')
      .then((response) => response.json())
      .then((result) => result.length ?
        setTrainings(result) :
        console.log('res', result))
      .finally(() => setIsLoading(false));
  }, []);

  const handleSubmit = (event: React.FormEvent<HTMLElement>) => {
    event.preventDefault();
    setIsSubmitting(true);
    const trainingApplication: TrainingApplication = {
      userName: userName,
      email: email,
      training: training,
    };
    apiFetchPost(
      '/api/trainingApplication',
      trainingApplication,
    ).then((response) => {
      if (response.ok) {
        setSuccess(true);
      } else {
        setError(true);
      }
    })
      .catch((error) => {
        console.log('Fetch Post', error);
        setError(true);
      })
      .finally(() => setIsSubmitting(false));
  };

  const nextTraining = () => {
    if (counter + 1 === trainings.length) {
      setCounter(0);
    } else {
      setCounter(counter + 1);
    }
    setTraining(trainings[counter]);
  };

  return (
    <ParentComponent
      title={BLOCK_TITLES.TRAINING}
      text={TRAINING_AND_CONSULTING_TEXT.TRAINING_TEXT}
    >
      {
        success ?
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
              <Input
                label={'Name'}
                onChange={(event) => setUserName(event.target.value)}
              />
              <Input
                label={'E-mail'}
                onChange={(event) => setEmail(event.target.value)}
              />
              {
                isLoading ?
                  <h3>No data. Loading...</h3> :
                  <>
                    <TrainingComponent training={trainings[counter]} />
                    <p
                      onClick={() => nextTraining()}
                      className="next-training"
                    >
                      Next training
                    </p>
                  </>
              }

              <Button
                title={'submit'}
                type={BUTTON_TYPES.DEFAULT}
                submitting={isSubmitting}
              />
            </form>
      }

    </ParentComponent>
  );
};

export const ConsultingPage = () => {
  const [success, setSuccess] = useState(false);
  const [error, setError] = useState(false);

  const [isSubmitting, setIsSubmitting] = useState(false);

  const [userName, setUserName] = useState('');
  const [email, setEmail] = useState('');
  const [convenientDay, setConvenientDay] = useState('');

  const handleSubmit = (event: React.FormEvent<HTMLElement>) => {
    event.preventDefault();
    setIsSubmitting(true);
    const consultingApplication: ConsultingApplication = {
      userName: userName,
      email: email,
      convenientDay: convenientDay,
    };
    apiFetchPost(
      '/api/consultingApplication',
      consultingApplication,
    ).then((response) => {
      if (response.ok) {
        setSuccess(true);
      } else {
        setError(true);
      }
    })
      .catch(() => {
        setError(true);
      })
      .finally(() => setIsSubmitting(false));
  };


  return (
    <ParentComponent
      title={BLOCK_TITLES.CONSULTING}
      text={TRAINING_AND_CONSULTING_TEXT.CONSULTING_TEXT}
    >      {
        success ?
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
              <Input
                label={'Name'}
                onChange={(event) => setUserName(event.target.value)}
              />
              <Input
                label={'E-mail'}
                onChange={(event) => setEmail(event.target.value)}
              />
              <Input
                label={'Convenient day'}
                onChange={(event) => setConvenientDay(event.target.value)}
              />
              <Button
                title={'submit'}
                type={BUTTON_TYPES.DEFAULT}
                submitting={isSubmitting}
              />
            </form>
      }
    </ParentComponent>
  );
};

