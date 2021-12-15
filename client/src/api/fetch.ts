const PATH = 'https://emotionalhelptest.azurewebsites.net';

export const apiFetch = async (path: string, array) => {
  await fetch(`${PATH}${path}`)
    .then((response) => response.json())
    .then((result) => array = result)
    .catch((error) => alert('Something went wrong: ' + error));
};
