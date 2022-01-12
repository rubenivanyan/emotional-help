import { INPUT_TYPES } from 'enums';

export type InputComponent = {
  label: string,
  onChange?,
  value?: string,
  type?: INPUT_TYPES,
  isRequired?: boolean
};
