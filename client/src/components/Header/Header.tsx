import React from 'react';
import './Header.scss';
import {Logo} from '../Logo/Logo';
import {Navbar} from '../Navbar/Navbar';
import {Registration} from '../Registration/Registration';

export const Header: React.FC = () => {
  return (
    <header className="header">
      <Logo />
      <Navbar />
      <Registration />
    </header>
  );
};
