import { mockedBooks } from '../common/mocks/books';
import { apiFetch } from './fetch';

export const getBooks = async () => {
  const books = await apiFetch('/api/Book');
  return books.length ? books : mockedBooks;
};
