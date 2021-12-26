import { Variant } from './variant';

export type QuestionWithVariants = {
  id?: number;
  variants?: Variant[];
  questionGroup?: string;
  formulation: string;
  imageUrl?: string;
};
