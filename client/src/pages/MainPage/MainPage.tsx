import React from 'react';
import './MainPage.scss';

export const MainPage = () => {
  return (
    <section className="main-page-container">
      <h2>Hello!</h2>
      <p>It is ours psychological help application</p>
      <p>
        There you can
        <a href="/testing" className="button">take the test</a>,
        join
        <a href="/training" className="button">training</a>
        and order
        <a href="/consulting" className="button">consulting</a>
      </p>
    </section>
  );
};
