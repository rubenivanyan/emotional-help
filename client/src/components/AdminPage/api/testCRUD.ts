import axios from 'axios';

export const getTests = async (app) => {
  const response = await axios.get(
    'https://emotional-help-api.azurewebsites.net/api/Test/',
  );
  console.log('GET', response.data);
  return await response.data;
};

export const putTests = async (body) => {
  console.log(body);
  const response = await axios.put(
    'https://emotional-help-api.azurewebsites.net/api/Test/',
    body,
  );
  console.log('PUT', response.data);
  return await response.data;
};

export const deleteTests = async (body) => {
  const response = await axios.delete(
    `https://emotional-help-api.azurewebsites.net/api/Test/${body.id}`,
    body,
  );
  console.log('DELETE', response.data);
  return await response.data;
};
