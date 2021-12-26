import React from 'react';
import { Outlet } from 'react-router-dom';
import './app.scss';
import { Footer, Header, Main } from 'components';


const App: React.FC = () => {
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
