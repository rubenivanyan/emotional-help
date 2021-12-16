import { Music } from '../../../common/types/music';
import React from 'react';

export const MusicComponent = ({ music }: { music: Music }) => {
  return (
    <>
      <h3>Song:</h3>
      <p>Title: {music.title}</p>
      <p>Executor: {music.executor}</p>
      <p>Genre: {music.genre}</p>
    </>
  );
};
