import React, { PropsWithChildren, useState } from 'react';
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
        Auth.isLogged ?
          <UserPanel /> :
          <Registration />
      }
    </div>
  );
};

const NavigationWrapper = ({ children, isOpened }:
  PropsWithChildren<{ isOpened?: boolean }>) => {
  return (
    <div className={'navigation-wrapper' + (isOpened ? ' opened' : '')}>
      {children}
    </div>
  );
};

export const Header: React.FC = () => {
  const [isOpened, setIsOpened] = useState(false);

  return (
    <header className="header">
      <Logo />
      <NavigationWrapper isOpened={isOpened}>
        <Navbar />
        <SearchRegWrapper />
      </NavigationWrapper>
      <button
        className={'menu-opener' + (isOpened ? ' active' : '')}
        onClick={() => setIsOpened(!isOpened)}
      />
    </header>
  );
};
