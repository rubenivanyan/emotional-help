import { Film } from '../../../common/types/film';
import React from 'react';

export const FilmComponent = ({ film }: { film?: Film }) => {
  return (
    <>
      <h3>Movie</h3>
      <p><b>Title:</b> {film?.title}</p>
      <p><b>Year:</b> {film?.year}</p>
      <p><b>Genre:</b> {film?.genre}</p>
    </>
  );
};
