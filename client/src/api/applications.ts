export const getApplications = async (url: string): Promise<any> => {
  const data = await fetch('https://api.github.com/users/RockStar666by/repos');
  return data;
};
