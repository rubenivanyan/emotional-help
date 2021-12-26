import { apiFetchGet } from 'api';

export const getLibraryItems = async (path: string, mockedData: any) => {
  const items = await apiFetchGet(path)
    .then((response) => response.json())
    .catch((error) => alert(`${path}: ${error}`));
  return items.length ? items : mockedData;
};
