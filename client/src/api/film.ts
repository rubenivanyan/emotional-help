import { mockedFilms } from '../common/mocks/films';
import { Film } from '../common/types/film';
import { apiFetch } from './fetch';

export const getFilms = (): Film[] => {
  let films: Film[];
  apiFetch('/api/Film', films);
  return films ? films : mockedFilms;
};
