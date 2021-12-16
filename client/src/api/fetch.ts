const PATH = 'https://emotionalhelptest.azurewebsites.net';

export const apiFetchLibraryItems = (path: string) => {
  return fetch(`${PATH}${path}`)
    .then((response) => response.json())
    .catch((error) => alert('Something went wrong: ' + error));
};

export const apiFetch = (path: string) => {
  return fetch(`${PATH}${path}`)
    .then((response) => response.json())
    .catch((error) => alert('Something went wrong: ' + error));
};
