import React, { useEffect } from 'react';
import { Outlet } from 'react-router-dom';
import { useDispatch } from 'react-redux';
import { BLOCKS_TITLES } from '../../../common/enums';
import { Block } from '../../Block/Block';
import { Info } from '../Info/Info';
import { appFetchRequest } from '../../../store/actions';
import './Applications.scss';
import axios from 'axios';

const body = {
  email: 'admin@email.com',
  password: 'Admin1!',
  rememberMe: true,
};

export const Applications = () => {
  const dispatch = useDispatch();
  useEffect(() => {
    axios
      .post('https://emotionalhelptest.azurewebsites.net/api/User/login', body)
      .then((response) => {
        console.log(response);
      })
      .catch((error) => {
        console.log(error);
      });
    console.log(document.cookie);
    setTimeout(() => {
      dispatch(appFetchRequest());
    }, 1000);
  }, []);

  return (
    <>
      <Block title={BLOCKS_TITLES.APPLICATIONS} percentWidth={25}>
        <Outlet />
      </Block>
      <Info />
    </>
  );
};
