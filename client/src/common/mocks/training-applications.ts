import {
  TrainingApplication,
} from '../types/training-application';
import { mockedTrainings } from './trainings';

export const mockedTrainingApplications: TrainingApplication[] = [
  {
    id: 0,
    isArchived: false,
    fullName: 'Example 1',
    email: 'example1@mail.com',
    trainingId: mockedTrainings[0].id,
  },
  {
    id: 1,
    isArchived: false,
    fullName: 'Example 2',
    email: 'example1@mail.com',
    trainingId: mockedTrainings[1].id,
  },
  {
    id: 2,
    isArchived: true,
    fullName: 'Example 3 Archived',
    email: 'example3@mail.com',
    trainingId: mockedTrainings[2].id,
  },
];
