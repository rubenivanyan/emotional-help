import React from 'react';
import './Header.scss';
import { Logo } from '../Logo/Logo';
import { Navbar } from '../Navbar/Navbar';
import { Registration } from '../Registration/Registration';
import { SearchBar } from '../../components/SearchBar/SearchBar';

export const Header: React.FC = () => {
  return (
    <header className="header">
      <Logo />
      <Navbar />
      <SearchBar />
      <Registration />
    </header>
  );
};
