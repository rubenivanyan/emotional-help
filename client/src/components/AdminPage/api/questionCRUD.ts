import axios from 'axios';

export const getQuestions = async (id) => {
  const response = await axios.get(
    `https://emotionalhelp.azurewebsites.net/api/Test/${id}/with-questions`,
  );
  console.log('GET', response.data);
  return await response.data;
};

export const putQuestions = async (body) => {
  const response = await axios.put(
    `https://emotionalhelp.azurewebsites.net/api/Question/${body.id}`,
    body,
  );
  console.log('PUT', response.data);
  return await response.data;
};

export const deleteQuestions = async (body) => {
  const response = await axios.delete(
    `https://emotionalhelp.azurewebsites.net/api/Question/${body.id}`,
    body,
  );
  console.log('DELETE', response.data);
  return await response.data;
};
