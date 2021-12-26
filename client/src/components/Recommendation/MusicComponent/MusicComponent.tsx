import React from 'react';
import { Music } from 'types';

export const MusicComponent = ({ music }: { music?: Music }) => {
  return (
    <>
      <h3>Song</h3>
      <p><b>Title:</b> {music?.title}</p>
      <p><b>Executor:</b> {music?.executor}</p>
      <p><b>Genre:</b> {music?.genre}</p>
    </>
  );
};
