import { Training } from './training';

export type TrainingApplication = {
  id?: number,
  userName: string;
  email: string;
  training: Training
};
