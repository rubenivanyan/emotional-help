import React, { useEffect, useState } from 'react';
import './Music.scss';
import { MusicCard } from '../MusicCard/MusicCard';
import axios from 'axios';
import { AddMusicCard } from '../MusicCard/AddMusicCard';

export const Music = () => {
  const [data, setData] = useState([]);
  useEffect(() => {
    axios
      .get('https://emotionalhelp.azurewebsites.net/api/Music')
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
      {data.map((music, index) => {
        return <MusicCard key={music.id} music={music} />;
      })}
      <AddMusicCard />
    </div>
  );
};
