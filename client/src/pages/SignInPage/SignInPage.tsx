import React, { useEffect, useState } from 'react';
import './SignInPage.scss';
import { Auth } from 'api';
import { BUTTON_TYPES } from 'enums';
import { UserLogin } from 'types';
import { Block, Success, Error, Button, Input } from 'components';

export const SignInPage = () => {
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [isRemember, setIsRemember] = useState(true);

  const [isSubmitting, setIsSubmitting] = useState(false);
  const [success, setSuccess] = useState(false);
  const [error, setError] = useState(false);
  const [errorMessage, setErrorMessage] = useState('');

  useEffect(() => {
    setIsRemember(isRemember);
  }, []);

  const handleSubmit = (event: React.FormEvent<HTMLElement>) => {
    event.preventDefault();

    const userLogin: UserLogin = {
      email: email,
      password: password,
      rememberMe: isRemember,
    };

    Auth.signIn(
      userLogin,
      setSuccess,
      setError,
      setErrorMessage,
      setIsSubmitting,
    );
  };

  return (
    <section className="sign-in-container">
      <Block title={'sign in'} percentWidth={50}>
        {
          Auth.isLogged() ?
            <h2>You are logged in already</h2> :
            success ?
              <Success /> :
              error ?
                <>
                  <Error error={errorMessage} />
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
