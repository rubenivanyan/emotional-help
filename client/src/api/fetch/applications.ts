import React from 'react';
import { apiFetchGet, apiFetchPost } from 'api';

export const getApplications =
  async (path: string, setIsGetting?, setApplications?) => {
    if (setIsGetting) setIsGetting(true);
    apiFetchGet(`${path}`)
      .then((response) => response.json())
      .then((response) => {
        return setApplications ?
          setApplications(response) :
          response;
      })
      .catch((error) => alert(`${path}: ${error}`))
      .finally(() => {
        if (setIsGetting) setIsGetting(false);
      });
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
