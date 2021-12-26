import { QuestionGroup } from './question-group';

export type Question = {
  id?: number;
  formulation: string;
  questionGroup: QuestionGroup;
  imageUrl?: string;
};
