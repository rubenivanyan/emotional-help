import React, { useEffect } from 'react';
import { Outlet } from 'react-router-dom';
import { useDispatch } from 'react-redux';
import { BLOCK_TITLES } from '../../../common/enums/block-titles';
import { Block } from '../../Block/Block';
import { Info } from '../Info/Info';
import { trainAppsFetchRequest } from '../../../store/actions';
import './Applications.scss';
import axios from 'axios';

export const Applications = () => {
  const dispatch = useDispatch();
  useEffect(() => {
    const body = {
      email: 'admin@email.com',
      password: 'Admin1!',
      rememberMe: true,
    };
    axios
      .post('https://emotional-help-api.azurewebsites.net/api/User/login', body)
      .then((response) => {
        console.log(response);
      })
      .catch((error) => {
        console.log(error);
      });
    setTimeout(() => {
      dispatch(trainAppsFetchRequest());
    }, 1000);
  }, []);

  return (
    <>
      <Block title={BLOCK_TITLES.APPLICATIONS} percentWidth={25}>
        <Outlet />
      </Block>
      <Info />
    </>
  );
};
