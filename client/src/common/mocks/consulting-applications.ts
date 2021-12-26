import {
  ConsultingApplication,
} from 'types';

export const mockedConsultingApplications: ConsultingApplication[] = [
  {
    id: 0,
    isArchived: false,
    fullName: 'Example 1',
    email: 'example1@mail.com',
    convenientDay: '22.10.2021',
    message: 'I have some example troubles 1',
  },
  {
    id: 1,
    isArchived: false,
    fullName: 'Example 2',
    email: 'example2@mail.com',
    convenientDay: '22.02.2022',
    message: 'I have some example troubles 2',
  },
  {
    id: 2,
    isArchived: true,
    fullName: 'Example 3',
    email: 'example3@mail.com',
    convenientDay: '22.10.2021',
    message: 'Archived example',
  },
];
