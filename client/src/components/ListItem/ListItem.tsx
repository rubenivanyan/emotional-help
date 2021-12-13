
import React, { PropsWithChildren } from 'react';
import { NavLink } from 'react-router-dom';
import './ListItem.scss';

export const ListItem = ({ link, children }:
  PropsWithChildren<{ link?: string }>) => {
  const listItem = <li className='list-item'>
    {children}
  </li>;

  return (
    link ?
      <NavLink to={link}>
        {listItem}
      </NavLink> :
      listItem
  );
};
