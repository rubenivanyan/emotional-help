import { mockedBooks } from '../common/mocks/books';
import { apiFetchLibraryItems } from './fetch';

export const getBooks = async () => {
  const books = await apiFetchLibraryItems('/api/Book');
  return books.length ? books : mockedBooks;
};
