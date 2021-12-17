import React, { useEffect, useState } from 'react';
import './Games.scss';
import { GameCard } from '../GameCard/GameCard';
import axios from 'axios';
import { AddGameCard } from '../GameCard/AddGameCard';

export const Games = () => {
  const [data, setData] = useState([]);
  useEffect(() => {
    axios
      .get('https://emotionalhelptest.azurewebsites.net/api/ComputerGame')
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
      {data.map((game, index) => {
        return <GameCard key={game.id} game={game} />;
      })}
      <AddGameCard />
    </div>
  );
};
