export const getApplications = async (url: string): Promise<any> => {
  const data = await fetch(
    'https://emotionalhelptest.azurewebsites.net/api/Application',
  );
  console.log('APPLICATION', data);
  return data;
};
