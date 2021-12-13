import React from 'react';
import './Navbar.scss';
import { NavLink } from 'react-router-dom';

export const Navbar: React.FC = () => {
  return (
    <nav className="navbar">
      <NavLink className="link" to="/admin">
        MAIN
      </NavLink>
      <NavLink className="link" to="/testing">
        TESTING
      </NavLink>
      <NavLink className="link" to="/training">
        TRAINING
      </NavLink>
      <NavLink className="link" to="/consulting">
        CONSULTING
      </NavLink>
    </nav>
  );
};
