import React, { PropsWithChildren, useState } from 'react';
import './Header.scss';
import { SearchBar, UserPanel, Registration, Logo, Navbar } from 'components';
import { useSelector } from 'react-redux';
import { RootState } from 'store/reducers/rootReducer';

const SearchRegWrapper = () => {
  const auth = useSelector((state: RootState) => state.auth);
  return (
    <div className="search-reg-wrapper">
      <SearchBar />
      {
        auth.isLogged ?
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
