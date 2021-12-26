import React, { useState } from 'react';
import { sendApplication, Auth, LocalStorage } from 'api';
import {
  BLOCK_TITLES,
  TRAINING_AND_CONSULTING_TEXT,
  BUTTON_TYPES,
} from 'enums';
import { ConsultingApplication } from 'types';
import { Success, Error, Button, Input } from 'components';
import { ParentComponent } from '../ParentComponent/ParentComponent';

export const ConsultingPage = () => {
  const [success, setSuccess] = useState(false);
  const [error, setError] = useState(false);

  const [isSubmitting, setIsSubmitting] = useState(false);

  const [convenientDay, setConvenientDay] = useState('');

  const handleSubmit = (event: React.FormEvent<HTMLElement>) => {
    event.preventDefault();
    setIsSubmitting(true);

    const consultingApplication: ConsultingApplication = {
      convenientDay: convenientDay,
    };

    sendApplication(
      '/api/ConsultingApplication',
      consultingApplication,
      setSuccess,
      setError,
      setIsSubmitting);
  };


  return (
    <ParentComponent
      title={BLOCK_TITLES.CONSULTING}
      text={TRAINING_AND_CONSULTING_TEXT.CONSULTING_TEXT}
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
              {
                Auth.isLogged() ?
                  <>
                    <p>
                      {`Dear ${LocalStorage.getItem('fullName')},
                    write a convenient day, please`}
                    </p>
                    <Input
                      label={'Convenient day'}
                      onChange={(event) => setConvenientDay(event.target.value)}
                    />
                    <Button
                      title={'submit'}
                      type={BUTTON_TYPES.DEFAULT}
                      submitting={isSubmitting}
                    />
                  </> :
                  <>
                    <p>
                      {
                        `Only authenticated users
                      can send application to ours specialist`
                      }
                    </p>
                    <a className="button" href="/sign-in">SIGN IN</a>
                    <a className="button" href="/sign-up">SIGN UP</a>
                  </>
              }
            </form>
      }
    </ParentComponent>
  );
};

