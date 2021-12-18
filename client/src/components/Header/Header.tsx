import React from 'react';
import './Header.scss';
import { Logo } from '../Logo/Logo';
import { Navbar } from '../Navbar/Navbar';
import { Registration } from '../Registration/Registration';
import { SearchBar } from '../../components/SearchBar/SearchBar';
import { LocalStorage } from '../../api/local-storage';

const SearchRegWrapper = () => {
  const isUserLocal = LocalStorage
    .getLocalStorage()
    .getItem('fullName');

  return (
    <div className="search-reg-wrapper">
      <SearchBar />
      {
        isUserLocal ?
        :
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
