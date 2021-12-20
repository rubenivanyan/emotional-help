import axios from 'axios';

export const getTrainApps = async (app) => {
  const response = await axios.get(
    'https://emotional-help-api.azurewebsites.net/api/ConsultingApplication/',
  );
  return await response.data;
};

export const putTrainApps = async (body) => {
  const response = await axios.put(
    `https://emotional-help-api.azurewebsites.net/api/Test/${body.id}`,
    body,
  );
  console.log('PUT', response.data);
  return await response.data;
};

export const deleteTrainApps = async (body) => {
  const response = await axios.delete(
    `https://emotional-help-api.azurewebsites.net/api/Test/${body.id}`,
    body,
  );
  console.log('DELETE', response.data);
  return await response.data;
};
