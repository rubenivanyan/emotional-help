import { Book, ComputerGame, Film, Music } from 'types';

export const mockedBooks: Book[] = [
  {
    id: 0,
    title: 'Some book 1',
    genre: { id: 0, title: 'example genre 1' },
    language: 'some lang 1',
    author: 'some author 1',
  },
  {
    id: 1,
    title: 'Some book 2',
    genre: { id: 1, title: 'example genre 2' },
    language: 'some lang 2',
    author: 'some author 2',
  },
  {
    id: 2,
    title: 'Some book 3',
    genre: { id: 2, title: 'example genre 3' },
    language: 'some lang 3',
    author: 'some author 3',
  },
];

export const mockedComputerGames: ComputerGame[] = [
  {
    id: 0,
    title: 'Some game 1',
    genre: { id: 0, title: 'example genre 1' },
    language: 'some lang 1',
    company: 'some company 1',
    review: 'some review 1',
  },
  {
    id: 1,
    title: 'Some game 2',
    genre: { id: 0, title: 'example genre 2' },
    language: 'some lang 2',
    company: 'some company 2',
    review: 'some review 2',
  },
  {
    id: 2,
    title: 'Some game 2',
    genre: { id: 0, title: 'example genre 2' },
    language: 'some lang 2',
    company: 'some company 2',
    review: 'some review 2',
  },
];

export const mockedFilms: Film[] = [
  {
    id: 0,
    title: 'Some book 1',
    genre: { id: 0, title: 'example genre 1' },
    language: 'some lang 1',
    year: 'some year 1',
  },
  {
    id: 1,
    title: 'Some book 2',
    genre: { id: 1, title: 'example genre 2' },
    language: 'some lang 2',
    year: 'some year 2',
  },
  {
    id: 2,
    title: 'Some book 3',
    genre: { id: 2, title: 'example genre 3' },
    language: 'some lang 3',
    year: 'some year 3',
  },
];

export const mockedMusic: Music[] = [
  {
    id: 0,
    title: 'Some book 1',
    genre: { id: 0, title: 'example genre 1' },
    language: 'some lang 1',
    executor: 'some executor 1',
  },
  {
    id: 1,
    title: 'Some book 2',
    genre: { id: 1, title: 'example genre 2' },
    language: 'some lang 2',
    executor: 'some executor 2',
  },
  {
    id: 2,
    title: 'Some book 3',
    genre: { id: 2, title: 'example genre 3' },
    language: 'some lang 3',
    executor: 'some executor 3',
  },
];
