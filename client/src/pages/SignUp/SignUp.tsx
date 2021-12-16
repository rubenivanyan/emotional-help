import './SignUp.scss';
import React, { useEffect, useState } from 'react';
import { Input } from '../../components/Input/Input';
import { UserRegistration } from '../../common/types/user-registration';
import { apiFetchPost } from '../../api/fetch';
import { Block } from '../../components/Block/Block';
import {
  Success,
  Error,
} from '../../pages/TrainingAndConsultingPages/TrainingAndConsultingPages';
import { Button } from '../../components/Button/Button';
import { BUTTON_TYPES } from '../../common/enums/button-types';

export const SignUpPage = () => {
  const [name, setName] = useState('');
  const [surname, setSurname] = useState('');
  const [email, setEmail] = useState('');
  const [birthDate, setBirthDate] = useState('2021-12-16T06:17:14.099Z');
  const [password, setPassword] = useState('');
  const [confirmPassword, setConfirmPassword] = useState('');

  const [isSubmitting, setIsSubmitting] = useState(false);
  const [success, setSuccess] = useState(false);
  const [error, setError] = useState(false);

  useEffect(() => {
    setBirthDate(birthDate);
  }, []);

  const handleSubmit = (event: React.FormEvent<HTMLElement>) => {
    event.preventDefault();
    setIsSubmitting(true);
    const userRegistration: UserRegistration = {
      name: name,
      surname: surname,
      email: email,
      birthDate: birthDate,
      password: password,
      confirmationPassword: confirmPassword,
    };
    apiFetchPost(
      '/api/User/register',
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
    <section className="sign-up-container">
      <Block title={'sign up'} percentWidth={50}>
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
                  label={'Name'}
                  onChange={(event) => setName(event.target.value)}
                />
                <Input
                  label={'Surname'}
                  onChange={(event) => setSurname(event.target.value)}
                />
                <Input
                  label={'E-mail'}
                  onChange={(event) => setEmail(event.target.value)}
                />
                <Input
                  label={'Password'}
                  onChange={(event) => setPassword(event.target.value)}
                />
                <Input
                  label={'Confirm password'}
                  onChange={(event) => setConfirmPassword(event.target.value)}
                />
                <Button
                  title={'sign up'}
                  type={BUTTON_TYPES.DEFAULT}
                  submitting={isSubmitting}
                />
              </form>
        }
      </Block>
    </section>
  );
};
