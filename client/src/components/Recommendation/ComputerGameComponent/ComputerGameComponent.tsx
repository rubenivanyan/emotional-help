import { ComputerGame } from '../../../common/types/computer-game';
import React from 'react';

export const ComputerGameComponent = ({ computerGame }:
  { computerGame: ComputerGame }) => {
  return (
    <>
      <h3>Video game:</h3>
      <p>Title: {computerGame.title}</p>
      <p>Company: {computerGame.company}</p>
      <p>Genre: {computerGame.genre}</p>
    </>
  );
};
