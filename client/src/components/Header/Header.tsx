import React from 'react';
import './Header.scss';
import { Logo } from '../Logo/Logo';
import { Navbar } from '../Navbar/Navbar';
import { Registration } from '../Registration/Registration';
import { SearchBar } from '../../components/SearchBar/SearchBar';
import { UserPanel } from '../../components/UserPanel/UserPanel';
import { Auth } from '../../api/auth';

const SearchRegWrapper = () => {
  return (
    <div className="search-reg-wrapper">
      <SearchBar />
      {
        Auth.isLogged() ?
          <UserPanel /> :
          <Registration />
      }
    </div>
  );
};

export const Header: React.FC = () => {
  return (
    <header className="header">
      <Logo />
      <Navbar />
      <SearchRegWrapper />
    </header>
  );
};
