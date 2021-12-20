const PATH = 'https://localhost:44390';

export const apiFetchPost = (path: string, item: any) => {
  const requestOptions: RequestInit = {
    method: 'POST',
    headers: { 'Content-Type': 'application/json' },
    body: JSON.stringify(item),
  };
  return fetch(PATH + path, requestOptions);
};

export const apiFetchPut = (path: string, item: any) => {
  const requestOptions: RequestInit = {
    method: 'PUT',
    headers: { 'Content-Type': 'application/json' },
    body: JSON.stringify(item),
  };
  return fetch(PATH + path, requestOptions);
};

export const apiFetchGet = async (path: string) => {
  return await fetch(PATH + path);
};
