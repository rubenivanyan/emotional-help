const PATH = 'https://emotionalhelptest.azurewebsites.net';

export const apiFetchLibraryItems = (path: string) => {
  return fetch(`${PATH}${path}`)
    .then((response) => response.json())
    .catch((error) => alert('Something went wrong: ' + error));
};

export const apiFetchPost = (path: string, item: any) => {
  const requestOptions = {
    method: 'POST',
    headers: { 'Content-Type': 'application/json' },
    body: JSON.stringify(item),
  };
  return fetch(`${PATH}${path}`, requestOptions)
    .then((response) => response.json());
};

export const apiFetchGet = async (path: string) => {
  return await fetch(`${PATH}${path}`)
    .then((response) => response.json());
};
