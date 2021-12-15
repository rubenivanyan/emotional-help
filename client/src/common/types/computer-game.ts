import { Genre } from './genre';

export type ComputerGame = {
  id: number;
  title: string;
  genre: Genre;
  language: string;
  company: string;
  review: string;
};
