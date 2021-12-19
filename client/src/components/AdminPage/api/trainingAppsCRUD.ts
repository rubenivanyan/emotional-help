import axios from 'axios';

export const getTrainingApplication = async (app) => {
  const response = await axios.get(
    'https://emotionalhelp.azurewebsites.net/api/ConsultingApplication/',
  );
  return await response.data;
};
