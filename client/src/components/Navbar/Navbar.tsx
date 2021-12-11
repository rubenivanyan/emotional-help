import React from 'react';
import './Navbar.scss';
import {NavLink} from 'react-router-dom';

export const Navbar: React.FC = () => {
  return (
    <nav className="navbar">
      <NavLink className="link" to="/">
        HOME
      </NavLink>
      <NavLink className="link" to="/help">
        NEED HELP?
      </NavLink>
      <NavLink className="link" to="/about">
        ABOUT US
      </NavLink>
      <NavLink className="link" to="/team">
        OUR TEAM
      </NavLink>
    </nav>
  );
};
