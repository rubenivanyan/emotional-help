import { Variant } from './variant';

export type TestResults = {
  id: number;
  dateOfResults: string;
  userId: string;
  userFullName: string;
  TestId: number;
  chosenVariants: Variant[];
};
