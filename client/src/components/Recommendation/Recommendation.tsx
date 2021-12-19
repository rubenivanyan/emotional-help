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
import { mockedBooks } from '../../common/mocks/books';
import { mockedMusic } from '../../common/mocks/music';
import { mockedFilms } from '../../common/mocks/films';
import { mockedComputerGames } from '../../common/mocks/computer-games';
import { getLibraryItems } from '../../api/fetch/library-items';


export const Recommendation = () => {
  const [isLoading, setIsLoading] = useState(true);
  const [counter, setCounter] = useState(0);

  const [books, setBooks] = useState([]);
  const [musics, setMusics] = useState([]);
  const [films, setFilms] = useState([]);
  const [computerGames, setComputerGames] = useState([]);

  useEffect(() => {
    const items = [
      { path: '/api/Book', mock: mockedBooks, setter: setBooks },
      { path: '/api/Music', mock: mockedMusic, setter: setMusics },
      { path: '/api/Film', mock: mockedFilms, setter: setFilms },
      {
        path: '/api/ComputerGame',
        mock: mockedComputerGames,
        setter: setComputerGames,
      },
    ];

    for (const item of items) {
      item.setter(getLibraryItems(item.path, item.mock) as any);
    }
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
              title={'next collection'}
              type={BUTTON_TYPES.DEFAULT}
              onClick={() => nextRecommendations()}
            />
          </>
      }
    </section>
  );
};
