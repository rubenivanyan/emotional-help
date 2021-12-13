import React from 'react';
import './AdminPage.scss';
import { Tabs } from '../../components/AdminPage/Tabs/Tabs';
import { Outlet } from 'react-router-dom';
import {
  Applications,
} from '../../components/AdminPage/Applications/Applications';

export const AdminPage: React.FC = () => {
  return (
    <section className="admin-page-container">
      <Tabs />
      <Applications>
        <Outlet />
      </Applications>
      {/* TO DO:
      1. Block with APPLICATION info
      2. That block is showed when one of New and Archived
      applications is chosen.
      3. Show users in separate block, not 'aplications' like it is doing now.
       */}
    </section>
  );
};
