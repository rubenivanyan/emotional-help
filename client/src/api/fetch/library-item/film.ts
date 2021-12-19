import { mockedFilms } from '../../../common/mocks/films';
import { apiFetchLibraryItems } from '../fetch';

export const getFilms = async () => {
  const films = await apiFetchLibraryItems('/api/Film');
  return films.length ? films : mockedFilms;
};
