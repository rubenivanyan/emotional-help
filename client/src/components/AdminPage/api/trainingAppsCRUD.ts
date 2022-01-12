import axios from 'axios';

export const getTrainApps = async (app) => {
  const response = await axios.get(
    'https://pslp-api.azurewebsites.net/api/ConsultingApplication/',
  );
  return await response.data;
};

export const putTrainApps = async (body) => {
  const response = await axios.put(
    `https://pslp-api.azurewebsites.net/api/Test/${body.id}`,
    body,
  );
  console.log('PUT', response.data);
  return await response.data;
};

export const deleteTrainApps = async (body) => {
  const response = await axios.delete(
    `https://pslp-api.azurewebsites.net/api/Test/${body.id}`,
    body,
  );
  console.log('DELETE', response.data);
  return await response.data;
};
