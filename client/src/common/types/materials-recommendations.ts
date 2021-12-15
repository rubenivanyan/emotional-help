import { Book } from './book';
import { ComputerGame } from './computer-game';
import { Film } from './film';
import { Music } from './music';

export type MaterialsRecommendations = {
  films: Film[];
  music: Music[];
  books: Book[];
  computerGames: ComputerGame[];
};
