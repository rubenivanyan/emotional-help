import React, { useEffect, useState } from 'react';
import './Books.scss';
import { BookCard } from '../BookCard/BookCard';
import axios from 'axios';
import { AddBookCard } from '../BookCard/AddBookCard';

export const Books = () => {
  const [data, setData] = useState([]);
  useEffect(() => {
    axios
      .get('https://emotional-help-api.azurewebsites.net/api/Book')
      .then((response) => {
        console.log(response.data);
        setData(response.data);
      })
      .catch((error) => {
        console.log(error);
      });
  }, []);
  return (
    <div className="tests-wrapper">
      {data.map((book, index) => {
        return <BookCard key={book.id} book={book} />;
      })}
      <AddBookCard />
    </div>
  );
};
