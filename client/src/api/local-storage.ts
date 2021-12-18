import { apiFetchGet } from './fetch';

export class LocalStorage {
  private static localStorage: Storage;

  private constructor() { };

  public static getLocalStorage(): Storage {
    if (!LocalStorage.localStorage) LocalStorage.localStorage = new Storage;
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
