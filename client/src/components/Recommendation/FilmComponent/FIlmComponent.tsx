import React from 'react';
import { Film } from 'types';

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
