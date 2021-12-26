import { Music } from '../../../common/types/music';
import React from 'react';

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
