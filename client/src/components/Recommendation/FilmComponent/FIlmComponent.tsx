import { Film } from '../../../common/types/film';
import React from 'react';

export const FilmComponent = ({ film }: { film: Film }) => {
  return (
    <>
      <h3>Movie:</h3>
      <p>Title: {film.title}</p>
      <p>Year: {film.year}</p>
      <p>Genre: {film.genre}</p>
    </>
  );
};
