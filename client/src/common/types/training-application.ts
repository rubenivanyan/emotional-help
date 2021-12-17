import { Training } from './training';

export type TrainingApplication = {
  id?: number;
  isArchived: boolean;
  fullName: string;
  email: string;
  training: Training
};
