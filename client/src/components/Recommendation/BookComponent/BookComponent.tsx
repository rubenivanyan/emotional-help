import { Book } from '../../../common/types/book';
import React from 'react';

export const BookComponent = ({ book }: { book: Book }) => {
  return (
    <>
      <h3>Book:</h3>
      <p>Title: {book.title}</p>
      <p>Author: {book.author}</p>
      <p>Genre: {book.genre}</p>
    </>
  );
};
