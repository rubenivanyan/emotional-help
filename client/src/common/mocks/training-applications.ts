import {
  TrainingApplication,
} from 'types';

export const mockedTrainingApplications: TrainingApplication[] = [
  {
    id: 0,
    isArchived: false,
    fullName: 'Example 1',
    email: 'example1@mail.com',
    trainingId: 0,
  },
  {
    id: 1,
    isArchived: false,
    fullName: 'Example 2',
    email: 'example1@mail.com',
    trainingId: 1,
  },
  {
    id: 2,
    isArchived: true,
    fullName: 'Example 3 Archived',
    email: 'example3@mail.com',
    trainingId: 2,
  },
];
