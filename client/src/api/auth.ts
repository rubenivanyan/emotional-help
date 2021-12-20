import { UserRegistration } from '../common/types/user-registration';
import { User } from '../common/types/user';
import { apiFetchGet, apiFetchPost } from './fetch/fetch';
import { LocalStorage } from './local-storage';
import { UserLogin } from '../common/types/user-login';

export class Auth {
  private static user: User | null = null;

  private constructor() { };

  public static signUp(
    userRegistration: UserRegistration,
    setSuccess,
    setError,
    setErrorMessage,
    setIsSubmitting,
  ): void {
    setIsSubmitting(true);

    apiFetchPost(
      '/api/User/register',
      userRegistration,
    )
      .then((response) => {
        if (response.status === 200) {
          setSuccess(true);
          Auth.login();
        } else {
          setError(true);
          setErrorMessage(response.statusText);
        }
      })
      .catch((error) => alert(`/api/User/register: ${error}`))
      .finally(() => setIsSubmitting(false));
  };

  public static signIn(
    userLogin: UserLogin,
    setSuccess,
    setError,
    setErrorMessage,
    setIsSubmitting,
  ): void {
    setIsSubmitting(true);

    apiFetchPost(
      '/api/User/login',
      userLogin,
    ).then((response) => {
      if (response.status === 200) {
        setSuccess(true);
        Auth.login();
      } else {
        setError(true);
        setErrorMessage(
          response.status !== 200 ?
            'Invalid e-mail/password' :
            '');
      }
    })
      .catch((error) => alert(`/api/User/login: ${error}`))
      .finally(() => setIsSubmitting(false));
  };

  public static login(): void {
    apiFetchGet('/api/User/account')
      .then<User>((response) => {
        return response.json();
      })
      .then((user) => {
        Auth.user = user;
        LocalStorage.setItemsFromObject(Auth.user);
      })
      .catch((error) => alert('api/User/account:' + error));
  };

  public static logout(): void {
    apiFetchGet('/api/User/logout')
      .then((response) => {
        if (response.status === 200) {
          LocalStorage.removeItemsFromObject(Auth.user);
          Auth.user = null;
        }
      })
      .catch((error) => alert('api/User/logout:' + error));
  };

  public static isLogged() {
    return LocalStorage.getItem('id') ? true : false;
  }
};


