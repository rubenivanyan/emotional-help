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
  isArchived?: boolean;
  fullName?: string;
  email?: string;
  convenientDay: string;
  message?: string;
};

export type TestingApplication = {
  id?: number;
  isArchived: boolean;
  fullName?: string,
  email?: string,
  testResultsId: number;
};

export type TrainingApplication = {
  id?: number;
  isArchived: boolean;
  userId?: string;
  fullName?: string;
  email?: string;
  trainingId: number
};
