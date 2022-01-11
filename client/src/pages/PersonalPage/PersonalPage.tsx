import React, { useEffect, useState } from 'react';
import './PersonalPage.scss';
import { LocalStorage, apiFetchPut, getApplications } from 'api';
import { BLOCK_TITLES, INPUT_TYPES, BUTTON_TYPES } from 'enums';
import { User } from 'types';
import { Block, Success, Error, Input, Button } from 'components';

export const PersonalPage = () => {
  const { fullName, email }: User = LocalStorage.getObject(
    [
      'fullName',
      'email',
      'birthDate',
    ]) as User;

  const [fullNameState, setFullName] = useState(fullName);
  const [emailState, setEmail] = useState(email);

  const [isSubmitting, setIsSubmitting] = useState(false);
  const [isGetting, setIsGetting] = useState(false);
  const [isSuccess, setSuccess] = useState(false);
  const [isError, setError] = useState(false);
  const [errorMessage, setErrorMessage] = useState('');

  const [testingApplications, setTestingApplications] =
    useState<any | null>(null);
  const [trainingApplications, setTrainingApplications] =
    useState<any | null>(null);
  const [consultingApplications, setConsultingApplications] =
    useState<any | null>(null);

  useEffect(() => {
    if (isError) setTimeout(() => setError(false), 3000);
  }, [isError]);

  const changedUser: User = {
    fullName: fullNameState,
    email: emailState,
    birthDate: '01.01.0001',
  };

  const handleSubmit = (event) => {
    event.preventDefault();

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

  const getHistory = () => {
    getApplications(
      '/api/TrainingApplication/userId',
      setIsGetting,
      setTestingApplications,
    );
    getApplications(
      '/api/TrainingApplication/userId',
      setIsGetting,
      setTrainingApplications,
    );
    getApplications(
      '/api/TrainingApplication/userId',
      setIsGetting,
      setConsultingApplications,
    );
  };

  return (
    <section className="personal-page-container">
      <Block title={BLOCK_TITLES.EDIT_PROFILE} percentWidth={30}>
        {isSuccess ?
          <Success message={'Saved successfully!'} /> :
          isError ?
            <Error error={errorMessage} /> :
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
              <Button
                title={isSubmitting ? 'saving...' : 'save'}
                type={BUTTON_TYPES.DEFAULT}
                submitting={isSubmitting}
              />
            </form>
        }
      </Block>
      <Block title={BLOCK_TITLES.HISTORY} percentWidth={60}>
        {testingApplications || trainingApplications || consultingApplications ?
          <p>
            {testingApplications}
            {trainingApplications}
            {consultingApplications}
          </p> :
          <Button
            title={isGetting ? 'getting...' : 'get history'}
            type={BUTTON_TYPES.DEFAULT}
            onClick={() => getHistory()}
            submitting={isGetting}
          />
          // TO DO: Style and check if null
        }
      </Block>
    </section>
  );
};
