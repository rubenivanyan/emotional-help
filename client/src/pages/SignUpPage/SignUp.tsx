import './SignUp.scss';
import React, { useState } from 'react';
import { Input } from '../../components/Input/Input';
import { UserRegistration } from '../../common/types/user-registration';
import { Block } from '../../components/Block/Block';
import { Success } from '../../components/Success/Success';
import { Error } from '../../components/Error/Error';
import { Button } from '../../components/Button/Button';
import { BUTTON_TYPES } from '../../common/enums/button-types';
import { Auth } from '../../api/auth';

export const SignUpPage = () => {
  const [name, setName] = useState('');
  const [surname, setSurname] = useState('');
  const [email, setEmail] = useState('');
  const [birthDate, setBirthDate] = useState('');
  const [password, setPassword] = useState('');
  const [confirmPassword, setConfirmPassword] = useState('');

  const [isSubmitting, setIsSubmitting] = useState(false);
  const [success, setSuccess] = useState(false);
  const [error, setError] = useState(false);
  const [errorMessage, setErrorMessage] = useState('');

  const handleSubmit = (event: React.FormEvent<HTMLElement>) => {
    event.preventDefault();
    const userRegistration: UserRegistration = {
      name: name,
      surname: surname,
      email: email,
      birthDate: birthDate,
      password: password,
      confirmationPassword: confirmPassword,
    };

    Auth.signUp(
      userRegistration,
      setSuccess,
      setError,
      setErrorMessage,
      setIsSubmitting,
    );
  };

  return (
    <section className="sign-up-container">
      <Block title={'sign up'} percentWidth={50}>
        {
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
                  label={'Name'}
                  onChange={(event) => setName(event.target.value)}
                />
                <Input
                  label={'Surname'}
                  onChange={(event) => setSurname(event.target.value)}
                />
                <Input
                  label={'Birth date'}
                  onChange={(event) => setBirthDate(event.target.value)}
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
