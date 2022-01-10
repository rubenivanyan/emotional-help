import React, { useEffect } from 'react';
import { Outlet } from 'react-router-dom';
import './app.scss';
import { Footer, Header, Main } from 'components';
import { useDispatch } from 'react-redux';
import { authFetchRequest } from 'store/actions';


const App: React.FC = () => {
  const dispatch = useDispatch();

  useEffect(() => {
    dispatch(authFetchRequest());
    console.log('dispatch APP');
  }, []);
  return (
    <>
      <Header />
      <Main>
        <Outlet />
      </Main>
      <Footer />
    </>
  );
};

export default App;
