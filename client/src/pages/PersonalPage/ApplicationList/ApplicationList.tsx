import React from 'react';

export const ApplicationList = (arraysOfApplications) => {
  return <>{
    arraysOfApplications.forEach((array) => {
      array.map((application, index) => {
        return (
          <li key={index}>
            <p>
              {
                (application.title && 'Training: ') ||
                (application.dateOfResults && 'Consulting: ')
              }
              {
                application.title || application.dateOfResults
              }
            </p>
          </li>
        );
      });
    })
  }</>;
};


