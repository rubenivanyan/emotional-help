import axios from 'axios';

export const getTrainingApplication = async (app) => {
  const response = await axios.get(
    'https://emotionalhelptest.azurewebsites.net/api/ConsultingApplication/',
  );
  return await response.data;
};
