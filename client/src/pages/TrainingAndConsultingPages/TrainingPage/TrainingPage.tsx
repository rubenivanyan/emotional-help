import { apiFetchGet } from '../../../api/fetch/fetch';
import { LocalStorage } from '../../../api/local-storage';
import { BLOCK_TITLES } from '../../../common/enums/block-titles';
import { BUTTON_TYPES } from '../../../common/enums/button-types';
import { TRAINING_AND_CONSULTING_TEXT } from '../../../common/enums/texts';
import { mockedTrainings } from '../../../common/mocks/trainings';
import { Training } from '../../../common/types/training';
import {
  TrainingApplication,
} from '../../../common/types/training-application';
import { Button } from '../../../components/Button/Button';
import { Input } from '../../../components/Input/Input';
import { Success } from '../../../components/Success/Success';
import { Error } from '../../../components/Error/Error';
import { TrainingComponent } from '../../../components/Training/Training';
import React, { useEffect, useState } from 'react';
import { ParentComponent } from '../ParentComponent/ParentComponent';
import { sendApplication } from '../../../api/fetch/applications';
import { useSelector } from 'react-redux';
import { RootState } from '../../../store/reducers/rootReducer';

export const TrainingPage = () => {
  const [success, setSuccess] = useState(false);
  const [error, setError] = useState(false);

  const [isSubmitting, setIsSubmitting] = useState(false);
  const [isLoading, setIsLoading] = useState(true);
  const [counter, setCounter] = useState(0);

  const [userName, setUserName] = useState('');
  const [email, setEmail] = useState('');
  const [trainingId, setTrainingId] = useState(0);
  const [trainings, setTrainings] = useState<Training[]>([]);

  const isLogged = useSelector((state: RootState) => state.user.isLogged);

  useEffect(() => {
    apiFetchGet('/api/training')
      .then((response) => response.json())
      .then((result) => setTrainings(
        result.length ?
          result :
          mockedTrainings,
      ))
      .finally(() => setIsLoading(false));
  }, []);

  const handleSubmit = (event: React.FormEvent<HTMLElement>) => {
    event.preventDefault();
    setIsSubmitting(true);

    const trainingApplication: TrainingApplication = {
      isArchived: false,
      fullName: userName,
      email: email,
      trainingId: trainingId,
    };

    sendApplication(
      '/api/TrainingApplication',
      trainingApplication,
      setSuccess,
      setError,
      setIsSubmitting,
    );
  };

  const nextTraining = () => {
    if (counter + 1 === trainings.length) {
      setCounter(0);
    } else {
      setCounter(counter + 1);
    }
    setTrainingId(trainings[counter].id);
  };

  return (
    <ParentComponent
      title={BLOCK_TITLES.TRAINING}
      text={TRAINING_AND_CONSULTING_TEXT.TRAINING_TEXT}
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
                isLogged ?
                  <p>
                    {`Dear ${LocalStorage.getItem('fullName')},
                    chose a training, please`}
                  </p> :
                  <>
                    <Input
                      label={'Name'}
                      onChange={
                        (event) => setUserName(event.target.value)
                      }
                    />
                    <Input
                      label={'E-mail'}
                      onChange={(event) => setEmail(event.target.value)}
                    />
                  </>
              }
              {
                isLoading ?
                  <h3>No data. Loading...</h3> :
                  <>
                    <TrainingComponent training={trainings[counter]} />
                    <p
                      onClick={() => nextTraining()}
                      className="next-training"
                    >
                      Next training
                    </p>
                  </>
              }

              <Button
                title={'submit'}
                type={BUTTON_TYPES.DEFAULT}
                submitting={isSubmitting}
              />
            </form>
      }

    </ParentComponent>
  );
};
