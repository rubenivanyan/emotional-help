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
import { TestingPage } from './pages/TestingPage/TestingPage';
import { MainPage } from './pages/MainPage/MainPage';
import {
  TrainingPage,
  ConsultingPage,
} from './pages/TrainingAndConsultingPages/TrainingAndConsultingPages';
import { SignUpPage } from './pages/SignUp/SignUp';

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
          <Route path="testing" element={<TestingPage />} />
          <Route path="training" element={<TrainingPage />} />
          <Route path="consulting" element={<ConsultingPage />} />
          <Route path="sign-up" element={<SignUpPage />} />
        </Route>
      </Routes>
    </Router>
  </React.StrictMode>,
  document.getElementById('root'),
);
