import { User } from '../common/types/user';
import { apiFetchGet } from './fetch';
import { LocalStorage } from './local-storage';

export class Auth {
  private static user: User | null = null;

  private constructor() { };

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
  }

  public static logout(): void {
    apiFetchGet('/api/User/logout')
      .then((response) => {
        if (response.status === 200) {
          LocalStorage.removeItemsFromObject(Auth.user);
          Auth.user = null;
        }
      })
      .catch((error) => alert('api/User/logout:' + error));
  }

  public static isLogged(): boolean {
    return Auth.user ? true : false;
  }
};


