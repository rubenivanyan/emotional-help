import { Variant } from './variant';
import { Question } from './question';

export type TestResultsForUser = {
  id: number;
  dateOfResults: string;
  userId: string;
  userFullName: string;
  TestId: number;
  questions: Question[];
  variants: Variant[];
};
