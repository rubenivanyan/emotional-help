import React from 'react';
import './AdminPage.scss';
import { AdminTabs } from '../../components/AdminTabs/AdminTabs';
import { Outlet } from 'react-router-dom';

export const AdminPage: React.FC = () => {
  return (
    <div className="admin-page-container">
      <AdminTabs />
      <div className="requests-container">
        <Outlet />
      </div>
    </div>
  );
};
