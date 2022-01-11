import React, { useEffect, useState } from 'react';
import { apiFetchGet, sendApplication, LocalStorage } from 'api';
import {
  BLOCK_TITLES,
  TRAINING_AND_CONSULTING_TEXT,
  BUTTON_TYPES,
} from 'enums';
import { Training, TrainingApplication } from 'types';
import {
  Success,
  Error,
  Button,
  TrainingComponent,
  AuthComponent,
} from 'components';
import { ParentComponent } from '../ParentComponent/ParentComponent';
import { useSelector } from 'react-redux';
import { RootState } from 'store/reducers/rootReducer';

export const TrainingPage = () => {
  const auth = useSelector((state: RootState) => state.auth);

  const [success, setSuccess] = useState(false);
  const [error, setError] = useState(false);

  const [isSubmitting, setIsSubmitting] = useState(false);
  const [isLoading, setIsLoading] = useState(true);
  const [counter, setCounter] = useState(0);

  const [trainingId, setTrainingId] = useState(0);
  const [trainings, setTrainings] = useState<Training[]>([]);

  useEffect(() => {
    apiFetchGet('/api/training')
      .then((response) => response.json())
      .then((result) => setTrainings(result))
      .catch((error) => alert('/api/training: ' + error))
      .finally(() => setIsLoading(false));
  }, []);

  const handleSubmit = (event: React.FormEvent<HTMLElement>) => {
    event.preventDefault();
    setIsSubmitting(true);

    const trainingApplication: TrainingApplication = {
      isArchived: false,
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
                auth.isLogged ?
                  <p>
                    {`Dear ${LocalStorage.getItem('fullName')},
                    chose a training, please`}
                  </p> :
                  <AuthComponent />
              }
              {
                auth.isLogged ?
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

                      <Button
                        title={'submit'}
                        type={BUTTON_TYPES.DEFAULT}
                        submitting={isSubmitting}
                      />
                    </> :
                  <></>
              }
            </form>
      }

    </ParentComponent>
  );
};
