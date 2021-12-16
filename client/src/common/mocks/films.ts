import { Film } from '../../common/types/film';

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
