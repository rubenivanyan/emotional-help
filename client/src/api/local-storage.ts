export class LocalStorage {
  private localStorage: Storage;

  private constructor() { };

  public getLocalStorage(): Storage {
    if (!this.localStorage) this.localStorage = new Storage;
    return this.localStorage;
  }
};
