import { QuestionWithVariants } from './question-with-variants';

export type TestWithQuestions = {
  questions: QuestionWithVariants[];
  id?: number;
  title: string;
};
