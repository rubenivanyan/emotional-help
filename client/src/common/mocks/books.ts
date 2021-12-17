import { Book } from '../../common/types/book';

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
