import { Genre } from './genre';

export type Book = {
  id: number;
  title: string;
  genre: Genre;
  language: string;
  author: string;
};
