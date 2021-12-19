import { apiFetchGet, apiFetchPost } from './fetch';
import React from 'react';

export const getApplications = async (path: string, mockedData: any) => {
  const applications = await apiFetchGet(`${path}`)
    .then((response) => response.json());
  return applications.length ?
    applications :
    mockedData;
};

export const sendApplication = (
  path: string,
  application: any,
  setSuccess: React.Dispatch<React.SetStateAction<boolean>>,
  setError: React.Dispatch<React.SetStateAction<boolean>>,
  setIsSubmitting: React.Dispatch<React.SetStateAction<boolean>>,
) => {
  apiFetchPost(
    `${path}`,
    application,
  ).then((response) => {
    if (response.status === 200) {
      setSuccess(true);
    } else {
      setError(true);
    }
  })
    .catch((error) => alert(`${path} : ${error}`))
    .finally(() => setIsSubmitting(false));
};
