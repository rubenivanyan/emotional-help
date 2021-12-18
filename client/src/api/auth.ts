import { User } from '../common/types/user';
import { apiFetchGet } from './fetch';
import { LocalStorage } from './local-storage';

export class Auth {
  private static user: User | null;

  private constructor() { };

  public static login(): void {
    apiFetchGet('/api/user/account')
      .then<User>((response) => {
        return response.json();
      })
      .then((user) => {
        Auth.user = user;
        LocalStorage.setItemsFromObject(Auth.user);
      })
      .catch((error) => alert('api/user/account:' + error));
  }

  public static logout(): void {
    apiFetchGet('/api/user/logout')
      .then((response) => {
        if (response.status === 200) {
          LocalStorage.removeItemsFromObject(Auth.user);
          Auth.user = null;
        }
      })
      .catch((error) => alert('api/user/logout:' + error));
  }

  public static isLogged(): boolean {
    return Auth.user ? true : false;
  }
};


