import { mockedMusic } from '../common/mocks/music';
import { apiFetch } from './fetch';

export const getMusics = async () => {
  const musics = await apiFetch('/api/Music');
  return musics.length ? musics : mockedMusic;
};
