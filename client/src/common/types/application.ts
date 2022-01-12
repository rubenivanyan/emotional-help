export type FullApplication = {
  id: number;
  userName: string;
  email: string;
  message: string;
  questionFormulation: string[];
  answerFormulation: string[];
  dateOfResults: string;
  isArchived: Boolean;
};

export type ConsultingApplication = {
  id?: number;
  userId?: number;
  isArchived?: boolean;
  userFullName?: string;
  email?: string;
  convenientDay: string;
  message?: string;
};

export type TestingApplication = {
  id?: number;
  isArchived: boolean;
  fullName?: string,
  userName?: string,
  email?: string,
  testResultsId?: number;
  questionsFormulations?: string[];
  answersFormulations?: string[];
  dateOfResults?: string;
};

export type TrainingApplication = {
  id?: number;
  isArchived: boolean;
  userId?: string;
  userFullName?: string;
  email?: string;
  title?: string;
  trainingId?: number;
};
