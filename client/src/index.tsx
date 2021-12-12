import React from 'react';
import ReactDOM from 'react-dom';
import App from './components/app/app';
import {BrowserRouter as Router, Route, Routes} from 'react-router-dom';
import './index.scss';
import {AdminPage} from './pages/AdminPage/AdminPage';
import {RequestsList} from './components/RequestsList/RequestsList';
import {UserCard} from './components/UserCard/UserCard';
import {UsersGrid} from './components/UsersGrid/UsersGrid';
import {PsychoGrid} from './components/PsychologistsGrid/PsychologistsGrid';

ReactDOM.render(
  <React.StrictMode>
    <Router>
      <Routes>
        <Route path="/" element={<App />}>
          <Route path="admin/*" element={<AdminPage />}>
            <Route index element={<RequestsList />} />
            <Route path="users" element={<UsersGrid />} />
            <Route path="psychologists" element={<PsychoGrid />} />
            <Route path="pending-requests" element={<RequestsList />} />
            <Route path="viewed-requests" element={<RequestsList />} />
            <Route path="deleted-requests" element={<RequestsList />} />
          </Route>
          <Route path="about" element={<UserCard />} />
          <Route path="help" element={<div>---Need Help?---</div>} />
          <Route path="team" element={<div>---Our team---</div>} />
        </Route>
      </Routes>
    </Router>
  </React.StrictMode>,
  document.getElementById('root'),
);
