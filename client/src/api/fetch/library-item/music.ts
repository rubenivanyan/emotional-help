import { mockedMusic } from '../../../common/mocks/music';
import { apiFetchLibraryItems } from '../fetch';

export const getMusics = async () => {
  const musics = await apiFetchLibraryItems('/api/Music');
  return musics.length ? musics : mockedMusic;
};
