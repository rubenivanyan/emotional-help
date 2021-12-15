import { Genre } from './genre';

export type VariantGenres = {
  id: number;
  formulation: string;
  genres: Genre[];
};
