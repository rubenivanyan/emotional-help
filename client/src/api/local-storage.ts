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

  public static removeItemsFromObject(object: Object): void {
    const localStorage = LocalStorage.getLocalStorage();
    for (const [key] of Object.keys(object)) {
      localStorage.removeItem(key);
    }
  }
};
