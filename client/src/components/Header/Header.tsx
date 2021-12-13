import React from 'react';
import './Header.scss';
import { Logo } from '../Logo/Logo';
import { Navbar } from '../Navbar/Navbar';
import { Registration } from '../Registration/Registration';
import { SearchBar } from '../../components/SearchBar/SearchBar';

const SearchRegWrapper = () => {
  return (
    <div className="search-reg-wrapper">
      <SearchBar />
      <Registration />
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
