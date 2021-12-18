import {
  mockedTrainingApplications,
} from '../common/mocks/training-applications';
import { apiFetchGet } from './fetch';

export const getTrainingApplication = async () => {
  const trainingApplication = await apiFetchGet('/api/consultingApplication')
    .then((response) => response.json());
  return trainingApplication.length ?
    trainingApplication :
    mockedTrainingApplications;
};
