const PATH = 'https://emotionalhelptest.azurewebsites.net';

export const apiFetch = (path: string) => {
  return fetch(`${PATH}${path}`)
    .then((response) => response.json())
    .catch((error) => alert('Something went wrong: ' + error));
};
