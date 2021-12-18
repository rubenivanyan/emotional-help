import { INPUT_TYPES } from '../../common/enums/input-types';

export type InputComponent = {
  label: string,
  onChange?,
  value?: string,
  type?: INPUT_TYPES,
  isRequired?: boolean
};
