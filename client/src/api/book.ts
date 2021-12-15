import { mockedBooks } from '../common/mocks/books';
import { Book } from '../common/types/book';
import { apiFetch } from './fetch';

export const getBooks = (): Book[] => {
  let books: Book[];
  apiFetch('/api/Book', books);
  return books ? books : mockedBooks;
};
