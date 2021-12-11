import React from 'react';
import './app.scss';
import {Header} from '../Header/Header';
import {Footer} from '../Footer/Footer';
import {Route, Routes} from 'react-router-dom';
import {AdminPage} from '../../pages/AdminPage/AdminPage';

const App: React.FC = () => {
  return (
    <div className="wrapper">
      <Header />
      <Routes>
        <Route path="/" element={<AdminPage />} />
        <Route path="/about" element={<div>---About Us---</div>} />
        <Route path="/help" element={<div>---Need Help?---</div>} />
        <Route path="/team" element={<div>---Our team---</div>} />
      </Routes>
      <Footer />
    </div>
  );
};
export default App;
