import { mockedComputerGames } from '../common/mocks/computer-games';
import { apiFetchLibraryItems } from './fetch';

export const getComputerGames = async () => {
  const computerGames = await apiFetchLibraryItems('/api/computerGame');
  return computerGames.length ? computerGames : mockedComputerGames;
};
