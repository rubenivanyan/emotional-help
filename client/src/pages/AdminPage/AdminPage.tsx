import React from 'react';
import './AdminPage.scss';
import { Outlet } from 'react-router-dom';
import { Tabs } from 'components/AdminPage/Tabs/Tabs';

export const AdminPage: React.FC = () => {
  return (
    <section className="admin-page-container">
      <Tabs />
      <Outlet />
    </section>
  );
};
