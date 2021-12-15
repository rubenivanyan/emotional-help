import { mockedMusic } from '../common/mocks/music';
import { Music } from '../common/types/music';
import { apiFetch } from './fetch';

export const getMusic = (): Music[] => {
  let music: Music[];
  apiFetch('/api/Music', music);
  return music ? music : mockedMusic;
};
