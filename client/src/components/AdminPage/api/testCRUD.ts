import axios from 'axios';

export const getTests = async (app) => {
  const body = {
    email: 'admin@email.com',
    password: 'Admin1!',
    rememberMe: true,
  };
  const response = await axios.post(
    'https://emotionalhelp.azurewebsites.net/api/Login',
    body,
  );
  console.log('GET', response.data);
  return await response.data;
};

export const putTests = async (body) => {
  const response = await axios.put(
    `https://emotionalhelptest.azurewebsites.net/api/Test/${body.id}`,
    body,
  );
  console.log('PUT', response.data);
  return await response.data;
};

export const deleteTests = async (body) => {
  const response = await axios.delete(
    `https://emotionalhelptest.azurewebsites.net/api/Test/${body.id}`,
    body,
  );
  console.log('DELETE', response.data);
  return await response.data;
};
