import { ConsultingApplication, TrainingApplication } from 'common/types';
import React from 'react';

export const ApplicationList = ({ applications }:
  { applications: ConsultingApplication[] | TrainingApplication[] }) => {
  return <>{
    applications.length ?
      applications.map((application, index) => {
        return (
          <li key={index} className="application-item">
            <p>
              {
                (application.title && 'Training: ') ||
                (application.convenientDay && 'Consulting: ')
              }
              {
                application.title || application.convenientDay
              }
            </p>
          </li>
        );
      }) :
      <></>
  }</>;
};


