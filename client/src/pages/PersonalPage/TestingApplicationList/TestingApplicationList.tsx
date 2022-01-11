import { TestingApplication } from 'common/types';
import React from 'react';

export const TestingApplicationList =
  ({ applications }: { applications: TestingApplication[]}) => {
    return (
      <>{
        applications.map((ta, index) => {
          return (
            <li key={index} className="testing-item">
              <p>Date: {ta.dateOfResults}</p>
              <p>Results:</p>
              <table>
                <thead>
                  <tr>
                    <td>Question:</td>
                    <td>Answer:</td>
                  </tr>
                </thead>
                <tbody>
                  {ta.questionsFormulations.map((qf, index) => {
                    return (
                      <tr key={index}>
                        <td>{qf[index]}</td>
                        <td>{ta.answersFormulations[index]}</td>
                      </tr>
                    );
                  })}
                </tbody>
              </table>
            </li>
          );
        })
      }</>
    );
  };
