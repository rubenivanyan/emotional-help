import { Book } from './book';
import { ComputerGame } from './computer-game';
import { Film } from './film';
import { Music } from './music';
import { QuestionGroup } from './question-group';
import { QuestionWithVariants } from './question-with-variants';
import { Variant } from './variant';

export type TestResults = {
  id?: number;
  dateOfResults?: string;
  userId?: string;
  testId: number;
  chosenVariants: Variant[];
  questions?: QuestionWithVariants[];
  questionGroupsValues?: QuestionGroup[];
  materialsRecommendations?: {
    books: Book[],
    computerGames: ComputerGame[],
    films: Film[],
    music: Music[],
  }
};
