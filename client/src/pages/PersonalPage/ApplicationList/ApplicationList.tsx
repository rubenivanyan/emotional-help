import React from 'react';

export const ApplicationList = (applications) => {
  return <>{
    applications.map((application, index) => {
      return (
        <li key={index} className="application-item">
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
    })
  }</>;
};


