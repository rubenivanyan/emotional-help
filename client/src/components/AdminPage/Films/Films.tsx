import React, { useEffect, useState } from 'react';
import './Films.scss';
import { FilmCard } from '../FilmCard/FilmCard';
import axios from 'axios';
import { AddFilmCard } from '../FilmCard/AddFilmCard';

export const Films = () => {
  const [data, setData] = useState([]);
  useEffect(() => {
    axios
      .get('https://pslp-api.azurewebsites.net/api/Film')
      .then((response) => {
        console.log(response.data);
        setData(response.data);
      })
      .catch((error) => {
        console.log(error);
      });
  }, []);
  return (
    <div className="tests-wrapper">
      {data.map((film, index) => {
        return <FilmCard key={film.id} film={film} />;
      })}
      <AddFilmCard />
    </div>
  );
};
