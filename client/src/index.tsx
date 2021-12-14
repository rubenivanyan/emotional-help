import React from 'react';
import ReactDOM from 'react-dom';
import App from './components/app/app';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import './index.scss';
import { AdminPage } from './pages/AdminPage/AdminPage';
import { RequestsList } from './components/AdminPage/RequestsList/RequestsList';
import { UsersGrid } from './components/AdminPage/UsersGrid/UsersGrid';
import {
  PsychoGrid,
} from './components/AdminPage/PsychologistsGrid/PsychologistsGrid';
import { Quiz } from './pages/QuizPage/QuizPage';
import { MainPage } from './pages/MainPage/MainPage';

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
          <Route path="" element={<MainPage />} />
          <Route path="testing" element={<Quiz />} />
          <Route path="training" element={<Quiz />} />
          <Route path="consulting" element={<div>---Our team---</div>} />
        </Route>
      </Routes>
    </Router>
  </React.StrictMode>,
  document.getElementById('root'),
);
