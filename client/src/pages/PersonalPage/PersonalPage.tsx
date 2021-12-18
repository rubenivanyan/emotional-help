import './PersonalPage.scss';
import React, { useEffect, useState } from 'react';
import { Block } from '../../components/Block/Block';
import { BLOCK_TITLES } from '../../common/enums/block-titles';
import { LocalStorage } from '../../api/local-storage';
import { User } from '../../common/types/user';
import { Input } from '../../components/Input/Input';
import { INPUT_TYPES } from '../../common/enums/input-types';
import { Button } from '../../components/Button/Button';
import { BUTTON_TYPES } from '../../common/enums/button-types';
import { apiFetchPut } from '../../api/fetch';
import { Success } from '../../components/Success/Success';
import { Error } from '../../components/Error/Error';
import { Auth } from '../../api/auth';

export const PersonalPage = () => {
  if (!Auth.isLogged()) {
    LocalStorage.setItemsFromObject(
      { fullName: 'name!', email: 'email!@asd.com', birthDate: '2021-10-21' });
  }
  const { fullName, email, birthDate }: User = LocalStorage.getObject(
    [
      'fullName',
      'email',
      'birthDate',
    ]) as User;

  const [fullNameState, setFullName] = useState(fullName);
  const [emailState, setEmail] = useState(email);
  const [birthDateState, setBirthDate] = useState(birthDate);

  const [isSubmitting, setIsSubmitting] = useState(false);
  const [isSuccess, setSuccess] = useState(false);
  const [isError, setError] = useState(false);
  const [errorMessage, setErrorMessage] = useState('');

  useEffect(() => {
    if (isError) setTimeout(() => setError(false), 2000);
  }, [isError]);

  const changedUser: User = {
    fullName: fullNameState,
    email: emailState,
    birthDate: birthDateState,
  };

  const handleSubmit = (event) => {
    event.preventDefault();
    setIsSubmitting(true);

    apiFetchPut('/api/User', changedUser)
      .then((response) => {
        if (response.status === 200) {
          setSuccess(true);
        } else {
          setError(true);
          setErrorMessage(response.statusText);
        }
      })
      .catch((error) => alert('/api/User' + error))
      .finally(() => setIsSubmitting(false));
  };

  return (
    isSuccess ?
      <Success message={'Saved successfully!'} /> :
      isError ?
        <Error error={errorMessage} /> :
        <section className="personal-page-container">
          <Block title={BLOCK_TITLES.PERSONAL_PAGE} percentWidth={100}>
            <form onSubmit={(e) => handleSubmit(e)}>
              <Input label={'Name'}
                onChange={(e) => setFullName(e.target.value)}
                value={fullNameState}
                isRequired={true}
              />
              <Input label={'E-mail'}
                onChange={(e) => setEmail(e.target.value)}
                value={emailState}
                type={INPUT_TYPES.EMAIL}
                isRequired={true}
              />
              <Input label={'Birthday'}
                onChange={(e) => setBirthDate(e.target.value)}
                value={birthDateState}
                type={INPUT_TYPES.DATE}
                isRequired={true}
              />
              <Button
                title={isSubmitting ? 'saving...' : 'save'}
                type={BUTTON_TYPES.DEFAULT}
                submitting={isSubmitting}
              />
            </form>
          </Block>
        </section>
  );
};
