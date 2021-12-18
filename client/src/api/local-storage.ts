import { apiFetchGet } from './fetch';

export class LocalStorage {
  private static localStorage: Storage = window.localStorage;

  private constructor() { };

  public static getLocalStorage(): Storage {
    return LocalStorage.localStorage;
  }

  public static setItemsFromObject(object: Object): void {
    const localStorage = LocalStorage.getLocalStorage();
    for (const [key, value] of Object.entries(object)) {
      localStorage.setItem(key, value);
    }
  }

  public static writeUser() {
    apiFetchGet('/api/user/account')
      .then((response) => LocalStorage.setItemsFromObject(response))
      .catch((error) => alert('api/user/account:' + error));
  };
};
