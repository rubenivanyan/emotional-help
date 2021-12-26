import { Training } from 'types';

export const mockedTrainings = (): Training[] => {
  return ([
    {
      id: 0,
      title: 'Do you like flexing?',
      startDate: '02.02.2022',
      description: `Lorem lorem lorem Lorem lorem lorem Lorem lorem lorem
      Lorem lorem lorem Lorem lorem lorem Lorem lorem lorem`,
    },
    {
      id: 1,
      title: 'Does flexing like you?',
      startDate: '03.03.2023',
      description: `Lorem lorem lorem Lorem lorem lorem Lorem lorem lorem
      Lorem lorem lorem Lorem lorem lorem Lorem lorem lorem`,
    },
    {
      id: 2,
      title: 'Hey, is anyone here?',
      startDate: '04.04.2024',
      description: `Lorem lorem lorem Lorem lorem lorem Lorem lorem lorem
      Lorem lorem lorem Lorem lorem lorem Lorem lorem lorem`,
    },
  ]);
};
