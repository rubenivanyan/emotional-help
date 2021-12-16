import { mockedComputerGames } from '../common/mocks/computer-games';
import { apiFetch } from './fetch';

export const getComputerGames = async () => {
  const computerGames = await apiFetch('/api/computerGame');
  return computerGames.length ? computerGames : mockedComputerGames;
};
