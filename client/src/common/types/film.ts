import { Genre } from './genre';

export type Film = {
  id: number;
  title: string;
  genre: Genre;
  language: string;
  year: string;
  videoUrl?: string;
};
