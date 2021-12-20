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
import { Applications } from './components/AdminPage/Applications/Applications';
import { Users } from './components/AdminPage/Users/Users';
import { Tests } from './components/AdminPage/Tests/Tests';
import { Library } from './components/AdminPage/Library/Library';
import { Questions } from './components/AdminPage/Questions/Questions';
import { TestingPage } from './pages/TestingPage/TestingPage';
import { MainPage } from './pages/MainPage/MainPage';
import {
  ConsultingPage,
} from './pages/TrainingAndConsultingPages/ConsultingPage/ConsultingPage';
import {
  TrainingPage,
} from './pages/TrainingAndConsultingPages/TrainingPage/TrainingPage';
import { SignUpPage } from './pages/SignUpPage/SignUp';
import { SignInPage } from './pages/SignInPage/SignInPage';
import { PersonalPage } from './pages/PersonalPage/PersonalPage';
import { NotFound } from './components/NotFound/NotFound';


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
              <Route path="library" element={<Library />}>
                <Route path="music" element={<UsersGrid />} />
                <Route path="films" element={<PsychoGrid />} />
                <Route path="books" element={<PsychoGrid />} />
                <Route path="games" element={<PsychoGrid />} />
              </Route>
              <Route path="tests" element={<Tests />}></Route>
              <Route path="questions" element={<Questions />}></Route>
              <Route path="questions/:id" element={<Questions />}></Route>
              <Route path="*" element={<NotFound />} />
            </Route>
            <Route path="*" element={<NotFound />} />
            <Route path="" element={<MainPage />} />
            <Route path="testing" element={<TestingPage />} />
            <Route path="training" element={<TrainingPage />} />
            <Route path="consulting" element={<ConsultingPage />} />
            <Route path="sign-up" element={<SignUpPage />} />
            <Route path="sign-in" element={<SignInPage />} />
            <Route path="personal-page" element={<PersonalPage />} />
          </Route>
        </Routes>
      </Router>
    </Provider>
  </React.StrictMode>,
  document.getElementById('root'),
);
