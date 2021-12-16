import './SignInPage.scss';
import React, { useEffect, useState } from 'react';

import { Input } from '../../components/Input/Input';
import { apiFetchPost } from '../../api/fetch';
import { Block } from '../../components/Block/Block';
import {
  Success,
  Error,
} from '../TrainingAndConsultingPages/TrainingAndConsultingPages';
import { Button } from '../../components/Button/Button';
import { BUTTON_TYPES } from '../../common/enums/button-types';
import { UserLogin } from '../../common/types/user-login';

export const SignInPage = () => {
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [isRemember, setIsRemember] = useState(true);

  const [isSubmitting, setIsSubmitting] = useState(false);
  const [success, setSuccess] = useState(false);
  const [error, setError] = useState(false);

  useEffect(() => {
    setIsRemember(isRemember);
  }, []);

  const handleSubmit = (event: React.FormEvent<HTMLElement>) => {
    event.preventDefault();
    setIsSubmitting(true);
    const userRegistration: UserLogin = {
      email: email,
      password: password,
      rememberMe: isRemember,
    };
    apiFetchPost(
      '/api/User/login',
      userRegistration,
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

  return (
    <section className="sign-in-container">
      <Block title={'sign in'} percentWidth={50}>
        {
          success ?
            <Success /> :
            error ?
              <>
                <Error />
                <Button title={'retry'}
                  type={BUTTON_TYPES.DEFAULT}
                  onClick={() => setError(false)} />
              </> :
              <form onSubmit={(event) => handleSubmit(event)}>
                <Input
                  label={'E-mail'}
                  onChange={(event) => setEmail(event.target.value)}
                />
                <Input
                  label={'Password'}
                  onChange={(event) => setPassword(event.target.value)}
                />
                <Button
                  title={'sign in'}
                  type={BUTTON_TYPES.DEFAULT}
                  submitting={isSubmitting}
                />
              </form>
        }
      </Block>
    </section>
  );
};
