import { Genre } from './genre';

export type Music = {
  id: number;
  title: string;
  genre: Genre;
  language: string;
  executor: string;
};
