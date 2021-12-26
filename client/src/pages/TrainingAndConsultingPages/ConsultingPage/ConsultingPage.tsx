import React, { useState } from 'react';
import { BLOCK_TITLES } from '../../../common/enums/block-titles';
import { TRAINING_AND_CONSULTING_TEXT } from '../../../common/enums/texts';
import { Button } from '../../../components/Button/Button';
import { BUTTON_TYPES } from '../../../common/enums/button-types';
import { Input } from '../../../components/Input/Input';
import {
  ConsultingApplication,
} from '../../../common/types/consulting-application';
import { Error } from '../../../components/Error/Error';
import { Success } from '../../../components/Success/Success';
import { LocalStorage } from '../../../api/local-storage';
import { ParentComponent } from '../ParentComponent/ParentComponent';
import { sendApplication } from '../../../api/fetch/applications';
import { Auth } from '../../../api/auth';

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

