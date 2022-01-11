import { ConsultingApplication, TrainingApplication } from 'types';

export const mockedConsultingApplications: ConsultingApplication[] = [
  {
    id: 0,
    isArchived: false,
    userFullName: 'Example 1',
    email: 'example1@mail.com',
    convenientDay: '22.10.2021',
    message: 'I have some example troubles 1',
  },
  {
    id: 1,
    isArchived: false,
    userFullName: 'Example 2',
    email: 'example2@mail.com',
    convenientDay: '22.02.2022',
    message: 'I have some example troubles 2',
  },
  {
    id: 2,
    isArchived: true,
    userFullName: 'Example 3',
    email: 'example3@mail.com',
    convenientDay: '22.10.2021',
    message: 'Archived example',
  },
];

export const mockedTrainingApplications: TrainingApplication[] = [
  {
    id: 0,
    isArchived: false,
    userFullName: 'Example 1',
    email: 'example1@mail.com',
    trainingId: 0,
  },
  {
    id: 1,
    isArchived: false,
    userFullName: 'Example 2',
    email: 'example1@mail.com',
    trainingId: 1,
  },
  {
    id: 2,
    isArchived: true,
    userFullName: 'Example 3 Archived',
    email: 'example3@mail.com',
    trainingId: 2,
  },
];
