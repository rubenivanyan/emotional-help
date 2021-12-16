import { getMusics } from '../../api/music';
import { getFilms } from '../../api/film';
import { getComputerGames } from '../../api/computer-game';
import { getBooks } from '../../api/book';
import React, { useEffect, useState } from 'react';
import './Recommendation.scss';
import { Button } from '../../components/Button/Button';
import { BUTTON_TYPES } from '../../common/enums/button-types';
import { BookComponent } from './BookComponent/BookComponent';
import { MusicComponent } from './MusicComponent/MusicComponent';
import { FilmComponent } from './FilmComponent/FIlmComponent';
import {
  ComputerGameComponent,
} from './ComputerGameComponent/ComputerGameComponent';

export const Recommendation = () => {
  const [isLoading, setIsLoading] = useState(true);
  const [counter, setCounter] = useState(0);

  const [books, setBooks] = useState([]);
  const [musics, setMusics] = useState([]);
  const [films, setFilms] = useState([]);
  const [computerGames, setComputerGames] = useState([]);

  useEffect(() => {
    getBooks().then((response) => setBooks(response));
    getMusics().then((response) => setMusics(response));
    getFilms().then((response) => setFilms(response));
    getComputerGames().then((response) => setComputerGames(response));
  }, []);

  useEffect(() => {
    if (books.length && musics.length && films.length && computerGames.length) {
      setIsLoading(false);
    }
  }, [books, musics, films, computerGames]);

  const nextRecommendations = () => {
    const minLength = Math.min(
      books.length,
      musics.length,
      films.length,
      computerGames.length,
    );
    if (counter + 1 < minLength) setCounter(counter + 1);
  };

  return (
    <section className="recommendation-container">
      <h2>RECOMMENDATIONS</h2>
      {
        isLoading ?
          <p>No data. Loading...</p> :
          <>
            <ul className="recommendation-list">
              <li className="recommendation-item">
                <BookComponent book={books[counter]} />
              </li>
              <li className="recommendation-item">
                <MusicComponent music={musics[counter]} />
              </li>
              <li className="recommendation-item">
                <FilmComponent film={films[counter]} />
              </li>
              <li className="recommendation-item">
                <ComputerGameComponent computerGame={computerGames[counter]} />
              </li>
            </ul>
            <Button
              title={'next'}
              type={BUTTON_TYPES.DEFAULT}
              onClick={() => nextRecommendations()}
            />
          </>
      }
    </section>
  );
};
