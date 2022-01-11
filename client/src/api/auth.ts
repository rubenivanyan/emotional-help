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
          response.status === 400 ?
            'Invalid e-mail/password' :
            'Something went wrong');
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
          LocalStorage.getLocalStorage().clear();
          window.location.reload();
        }
      })
      .catch((error) => alert('api/User/logout:' + error));
  };

  public static async isLogged() {
    let isLogged;
    let isAdmin;

    await apiFetchGet('/api/User/is-authenticated')
      .then<boolean>((response) => response.json())
      .then((response) => isLogged = response)
      .catch((error) => alert('/api/User/is-authenticated' + error));
    console.log('isLogged() ', isLogged);

    await apiFetchGet('/api/User/is-in-role/Administrator')
      .then<boolean>((response) => response.json())
      .then((response) => isAdmin = response)
      .catch((error) => alert('/api/User/is-in-role/ ' + error));
    console.log('isLogged() isAdmin ', isAdmin);

    if (!isLogged) LocalStorage.getLocalStorage().clear();
    if (isAdmin) {
      LocalStorage
        .getLocalStorage()
        .setItem('isAdmin', `${isAdmin}`);
    }

    return { isLogged, isAdmin };
  }
};


