import './Training.scss';
import React from 'react';
import { Training } from 'types';

export const TrainingComponent = ({ training }: { training?: Training }) => {
  return (
    training ?
      <section className="training-container" >
        <h3>Training: «{training.title}»</h3>
        <ul className="training-list">
          <li className="training-item">
            <b>Start Date: </b>
            {training.startDate}
          </li>
          <li className="training-item">
            <b>Description: </b>
            {training.description}
          </li>
        </ul>
      </section> :
      <h3>No trainings are available</h3>
  );
};
