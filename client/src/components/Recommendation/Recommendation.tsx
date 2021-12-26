import React, { PropsWithChildren, useEffect, useState } from 'react';
import './Recommendation.scss';
import { BUTTON_TYPES } from 'enums';
import { Button } from 'components';
import { BookComponent } from './BookComponent/BookComponent';
import {
  ComputerGameComponent,
} from './ComputerGameComponent/ComputerGameComponent';
import { FilmComponent } from './FilmComponent/FIlmComponent';
import { MusicComponent } from './MusicComponent/MusicComponent';

export const Recommendation = ({
  books,
  computerGames,
  films,
  music,
}: PropsWithChildren<any>) => {
  const [counter, setCounter] = useState(0);

  const [booksState, setBooks] = useState([]);
  const [computerGamesState, setComputerGames] = useState([]);
  const [filmsState, setFilms] = useState([]);
  const [musicsState, setMusics] = useState([]);

  useEffect(() => {
    setBooks(books);
    setComputerGames(computerGames);
    setFilms(films);
    setMusics(music);
  }, [books, music, films, computerGames]);


  const nextRecommendations = () => {
    const minLength = Math.min(
      booksState.length,
      musicsState.length,
      filmsState.length,
      computerGamesState.length,
    );
    if (counter + 1 < minLength) setCounter(counter + 1);
  };

  return (
    <section className="recommendation-container">
      <h2>RECOMMENDATIONS</h2>
      <ul className="recommendation-list">
        {
          booksState[0] &&
          <li className="recommendation-item">
            <BookComponent book={booksState[counter]} />
          </li>
        }
        {
          musicsState[0] &&
          <li className="recommendation-item">
            <MusicComponent music={musicsState[counter]} />
          </li>
        }
        {
          filmsState[0] &&
          <li className="recommendation-item">
            <FilmComponent film={filmsState[counter]} />
          </li>
        }
        {
          computerGamesState[0] &&
          <li className="recommendation-item">
            <ComputerGameComponent computerGame={computerGamesState[counter]} />
          </li>
        }
      </ul>
      <Button
        title={'next collection'}
        type={BUTTON_TYPES.DEFAULT}
        onClick={() => nextRecommendations()}
      />
    </section>
  );
};
