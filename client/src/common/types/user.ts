export type User = {
  id?: string
  fullName: string;
  email: string;
  birthDate: string;
};

export type UserRegistration = {
  name: string;
  surname: string;
  email: string;
  birthDate: string;
  password: string;
  confirmationPassword: string;
};

export type UserLogin = {
  email: string;
  password: string;
  rememberMe: boolean;
};

export type UserEdit =
  Omit<UserRegistration, 'password' | 'confirmationPassword'>;
