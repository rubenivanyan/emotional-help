import { Variant } from './variant';

export type FullQuestion = {
  id: number;
  formulation: string;
  imageUrl?: string;
  variants: Variant[];
};
