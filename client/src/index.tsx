import React from 'react';
import ReactDOM from 'react-dom';
import { Provider } from 'react-redux';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import { store } from './store/store';
import App from './components/app/app';
import './index.scss';
import { AdminPage } from './pages/AdminPage/AdminPage';
import { RequestsList } from './components/AdminPage/RequestsList/RequestsList';
import { UsersGrid } from './components/AdminPage/UsersGrid/UsersGrid';
// eslint-disable-next-line
import { PsychoGrid } from './components/AdminPage/PsychologistsGrid/PsychologistsGrid';
import { Quiz } from './pages/QuizPage/QuizPage';
import { Applications } from './components/AdminPage/Applications/Applications';
import { Users } from './components/AdminPage/Users/Users';

ReactDOM.render(
  <React.StrictMode>
    <Provider store={store}>
      <Router>
        <Routes>
          <Route path="/" element={<App />}>
            <Route path="admin/*" element={<AdminPage />}>
              <Route index element={<Users />} />
              <Route path="requests" element={<Applications />}>
                <Route index element={<RequestsList />} />
                <Route path="pending-requests" element={<RequestsList />} />
                <Route path="deleted-requests" element={<RequestsList />} />
              </Route>
              <Route path="users" element={<Users />}>
                <Route index element={<UsersGrid />} />
                <Route path="users" element={<UsersGrid />} />
                <Route path="psychologists" element={<PsychoGrid />} />
              </Route>
              <Route path="library" element={<RequestsList />}>
                <Route path="music" element={<UsersGrid />} />
                <Route path="films" element={<PsychoGrid />} />
                <Route path="books" element={<PsychoGrid />} />
                <Route path="games" element={<PsychoGrid />} />
              </Route>
              <Route path="tests" element={<RequestsList />} />
              <Route path="*" element={<p>404</p>} />
            </Route>
            <Route path="testing" element={<Quiz />} />
            <Route path="training" element={<Quiz />} />
            <Route path="consulting" element={<div>---Our team---</div>} />
            <Route path="*" element={<p>404</p>} />
          </Route>
        </Routes>
      </Router>
    </Provider>
  </React.StrictMode>,
  document.getElementById('root'),
);
