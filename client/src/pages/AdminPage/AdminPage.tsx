import React from 'react';
import './AdminPage.scss';
import {AdminTabs} from '../../components/AdminTabs/AdminTabs';

export const AdminPage: React.FC = () => {
  return (
    <div className="admin-page-container">
      ADMIN PAGE
      <AdminTabs />
    </div>
  );
};
