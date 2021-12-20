import { FullQuestion } from './full-question';

export type FullTest = {
  id: number;
  title: string;
  typeOfTest: string;
  questions: FullQuestion[];
};
