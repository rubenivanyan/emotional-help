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
import { apiFetchPut } from '../../api/fetch/fetch';
import { Success } from '../../components/Success/Success';
import { Error } from '../../components/Error/Error';
import { getApplications } from '../../api/fetch/applications';
import { useSelector } from 'react-redux';
import { RootState } from '../../store/reducers/rootReducer';

export const PersonalPage = () => {
  const isLogged = useSelector((state: RootState) => state.user.isLogged);

  if (!isLogged) {
    LocalStorage.setItemsFromObject(
      { fullName: 'name!', email: 'email!@asd.com', birthDate: '2021-10-21' });
  }

  const { id, fullName, email, birthDate }: User = LocalStorage.getObject(
    [
      'id',
      'fullName',
      'email',
      'birthDate',
    ]) as User;

  const [fullNameState, setFullName] = useState(fullName);
  const [emailState, setEmail] = useState(email);
  const [birthDateState, setBirthDate] = useState(birthDate);

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
    birthDate: birthDateState,
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
      `/api/TestingApplication/${id}`,
      setIsGetting,
      setTestingApplications,
    );
    getApplications(
      `/api/TrainingApplication/${id}`,
      setIsGetting,
      setTrainingApplications,
    );
    getApplications(
      `/api/ConsultingApplication/${id}`,
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
