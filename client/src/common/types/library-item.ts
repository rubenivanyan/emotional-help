export type Book = {
  id: number;
  title: string;
  genre: Genre;
  language: string;
  author: string;
};

export type ComputerGame = {
  id: number;
  title: string;
  genre: Genre;
  language: string;
  company: string;
  review: string;
};

export type Film = {
  id: number;
  title: string;
  genre: Genre;
  language: string;
  year: string;
  videoUrl?: string;
};

export type Music = {
  id: number;
  title: string;
  genre: Genre;
  language: string;
  executor: string;
};

export type Genre = {
  id: number;
  title: string;
};
