import { getMusic } from '../../api/music';
import { getFilms } from '../../api/film';
import { getComputerGames } from '../../api/computer-game';
import { getBooks } from '../../api/book';
import React, { useEffect, useState } from 'react';
import './Recommendation.scss';

export const Recommendation = () => {
  const [isLoading, setIsLoading] = useState(true);
  let isLoaded = false;

  const [books, setBooks] = useState([]);
  const [music, setMusic] = useState([]);
  const [films, setFilms] = useState([]);
  const [computerGames, setComputerGames] = useState([]);

  useEffect(() => {
    setBooks(getBooks());
    setMusic(getMusic());
    setFilms(getFilms());
    setComputerGames(getComputerGames());

    isLoaded = books && music && films && computerGames ? true : false;
  }, []);

  useEffect(() => {
    if (isLoaded) {
      setIsLoading(false);
    }
  }, [isLoaded]);

  return (
    <>
      <h2>RECOMMENDATIONS</h2>
      {
        isLoading ?
          <p>Loading...</p> :
          <p>LOADED!!!!</p>
      }
    </>
  );
};
