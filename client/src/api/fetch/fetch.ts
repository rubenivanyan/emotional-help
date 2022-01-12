const PATH = 'https://pslp-api.azurewebsites.net';

export const apiFetchPost = async (path: string, item: any) => {
  const requestOptions: RequestInit = {
    method: 'POST',
    headers: { 'Content-Type': 'application/json' },
    credentials: 'include',
    body: JSON.stringify(item),
  };
  return await fetch(PATH + path, requestOptions);
};

export const apiFetchPut = (path: string, item: any) => {
  const requestOptions: RequestInit = {
    method: 'PUT',
    headers: { 'Content-Type': 'application/json' },
    credentials: 'include',
    body: JSON.stringify(item),
  };
  return fetch(PATH + path, requestOptions);
};

export const apiFetchGet = async (path: string) => {
  return await fetch(PATH + path, {
    credentials: 'include',
  });
};
