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

  public static getItem(key: string): string {
    const localStorage = LocalStorage.getLocalStorage();
    return localStorage.getItem(key);
  }

  public static getItems(keys: string[]): string[] {
    let values: string[];
    for (const key of keys) {
      values.push(LocalStorage.getItem(key));
    }
    return values;
  }

  public static getObject(keys: string[]): Object {
    const object: Object = {};
    for (const key of keys) {
      object[key] = LocalStorage.getItem(key);
    }
    return object;
  }
};


