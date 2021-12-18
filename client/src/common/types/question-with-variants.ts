import { Variant } from './variant';

export type QuestionWithVariants = {
  id?: number;
  variants: Variant[];
  formulation: string;
  imageUrl?: string;
};
