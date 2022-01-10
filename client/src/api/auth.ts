import { apiFetchPost, apiFetchGet, LocalStorage } from 'api';
import { User, UserRegistration, UserLogin } from 'types';
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
          Auth.getAccount();
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
        Auth.getAccount();
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

  public static getAccount(): void {
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
    apiFetchPost('/api/User/logout', '')
      .then((response) => {
        if (response.status === 200) {
          LocalStorage.removeItemsFromObject(Auth.user);
          Auth.user = null;
        }
      })
      .catch((error) => alert('api/User/logout:' + error));
  };

  public static async isLogged() {
    let isLogged;
    await apiFetchGet('/api/User/is-authenticated')
      .then<boolean>((response) => response.json())
      .then((response) => isLogged = response)
      .catch((error) => alert('/api/User/is-authenticated' + error));
    console.log('isLogged() ', isLogged);

    if (!isLogged) LocalStorage.getLocalStorage().clear();

    return isLogged;
  }
};


