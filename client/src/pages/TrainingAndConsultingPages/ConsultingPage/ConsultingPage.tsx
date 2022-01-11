import React, { useState } from 'react';
import { sendApplication, LocalStorage } from 'api';
import {
  BLOCK_TITLES,
  TRAINING_AND_CONSULTING_TEXT,
  BUTTON_TYPES,
} from 'enums';
import { ConsultingApplication } from 'types';
import { Success, Error, Button, Input, AuthComponent } from 'components';
import { ParentComponent } from '../ParentComponent/ParentComponent';
import { useSelector } from 'react-redux';
import { RootState } from 'store/reducers/rootReducer';

export const ConsultingPage = () => {
  const auth = useSelector((state: RootState) => state.auth);
  console.log('auth.isLogged: ', auth.isLogged);

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
                auth.isLogged ?
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
                  <AuthComponent />
              }
            </form>
      }
    </ParentComponent>
  );
};

