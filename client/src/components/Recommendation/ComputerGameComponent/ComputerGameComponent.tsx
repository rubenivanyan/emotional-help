import { ComputerGame } from '../../../common/types/computer-game';
import React from 'react';

export const ComputerGameComponent = ({ computerGame }:
  { computerGame?: ComputerGame }) => {
  return (
    <>
      <h3>Video game</h3>
      <p><b>Title:</b> {computerGame?.title}</p>
      <p><b>Company:</b> {computerGame?.company}</p>
      <p><b>Genre:</b> {computerGame?.genre}</p>
    </>
  );
};
