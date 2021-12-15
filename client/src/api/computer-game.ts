import { mockedComputerGames } from '../common/mocks/computer-games';
import { ComputerGame } from '../common/types/computer-game';
import { apiFetch } from './fetch';

export const getComputerGames = (): ComputerGame[] => {
  let computerGames: ComputerGame[];
  apiFetch('/api/computerGame', computerGames);
  return computerGames ? computerGames : mockedComputerGames;
};
