import { Book, ComputerGame, Film, Genre, Music } from 'types';
import { QUESTION_GROUPS } from 'enums';

export type Test = {
  id?: number;
  title: string;
};

export type FullTest = {
  id: number;
  title: string;
  typeOfTest: string;
  questions: FullQuestion[];
};

export type Question = {
  id?: number;
  formulation: string;
  questionGroup: QuestionGroup;
  imageUrl?: string;
};

export type FullQuestion = {
  id: number;
  formulation: string;
  imageUrl?: string;
  variants: Variant[];
};

export type QuestionWithVariants = {
  id?: number;
  variants?: Variant[];
  questionGroup?: string;
  formulation: string;
  imageUrl?: string;
};

export type QuestionGroup = {
  group: QUESTION_GROUPS;
  value?: number;
};

export type TestWithQuestions = {
  questions: QuestionWithVariants[];
  id?: number;
  title: string;
};

export type TestingResults = {
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

export type TestingResultsValues = {
  neurosis: number,
  socialAnxiety: number,
  depression: number,
  asthenia: number,
};

export type TestingResultsForUser = {
  id: number;
  dateOfResults: string;
  userId: string;
  userFullName: string;
  TestId: number;
  questions: Question[];
  variants: Variant[];
};

export type MaterialsRecommendations = {
  films: Film[];
  music: Music[];
  books: Book[];
  computerGames: ComputerGame[];
};

export type Variant = {
  id?: number;
  formulation: string;
};

export type VariantGenres = {
  id: number;
  formulation: string;
  genres: Genre[];
};
