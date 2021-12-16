import { mockedFilms } from '../common/mocks/films';
import { apiFetch } from './fetch';

export const getFilms = async () => {
  const films = await apiFetch('/api/Film');
  return films.length ? films : mockedFilms;
};
