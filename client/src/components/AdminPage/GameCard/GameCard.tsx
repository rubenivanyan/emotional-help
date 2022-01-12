import * as React from 'react';
import Card from '@mui/material/Card';
import CardActions from '@mui/material/CardActions';
import CardContent from '@mui/material/CardContent';
import Typography from '@mui/material/Typography';
import './GameCard.scss';
import { useState } from 'react';
import { TextField } from '@mui/material';
import PropTypes from 'prop-types';
import axios from 'axios';

export const GameCard = (props) => {
  const [showForm, setShowForm] = useState(false);
  const [title, setTitle] = useState(props.game.title);
  const [id, setId] = useState(props.game.id);
  const [language, setLanguage] = useState(props.game.language);
  const [genre, setGenre] = useState(props.game.genre);
  const [company, setCompany] = useState(props.game.company);
  const [review, setReview] = useState(props.game.review);

  const body = {
    id: id,
    title: title,
    language: language,
    genre: genre,
    company: company,
    review: review,
  };

  const handleChangeTitle = (event: React.ChangeEvent<HTMLInputElement>) => {
    setTitle(event.target.value);
  };
  const handleChangeId = (event: React.ChangeEvent<HTMLInputElement>) => {
    setId(event.target.value);
  };
  const handleChangeLanguage = (event: React.ChangeEvent<HTMLInputElement>) => {
    setLanguage(event.target.value);
  };
  const handleChangeGenre = (event: React.ChangeEvent<HTMLInputElement>) => {
    setGenre(event.target.value);
  };
  const handleChangeCompany = (event: React.ChangeEvent<HTMLInputElement>) => {
    setCompany(event.target.value);
  };
  const handleChangeReview = (event: React.ChangeEvent<HTMLInputElement>) => {
    setReview(event.target.value);
  };

  const handleShowForm = () => {
    setShowForm(!showForm);
    console.log(showForm);
  };

  const handleSubmitTest = () => {
    handleShowForm();
    console.log('SUBMIT');
    axios
      .put(
        'https://pslp-api.azurewebsites.net/api/ComputerGame',
        body,
      )
      .then((response) => {
        console.log(response);
      })
      .catch((error) => {
        console.log(body);
        console.log(error);
      });
    // We know, its forbidden. We used sagas already,
    // but we had no time to refactor this part of our code
    // due to big volume of redux actions and reducers to compose.
    setTimeout(() => {
      window.location.reload();
    }, 1000);
  };

  const handleDelete = () => {
    axios
      .delete(
        `https://pslp-api.azurewebsites.net/api/ComputerGame/${id}`,
      )
      .then((response) => {
        console.log(response);
      })
      .catch((error) => {
        console.log(error);
      });
    // We know, its forbidden. We used sagas already,
    // but we had no time to refactor this part of our code
    // due to big volume of redux actions and reducers to compose.
    setTimeout(() => {
      window.location.reload();
    }, 1000);
  };

  return (
    <Card sx={{ width: 250, margin: 1, minHeight: 135 }}>
      {showForm ? (
        <>
          <TextField
            id="outlined-basic"
            label="Title"
            value={title}
            onChange={handleChangeTitle}
            size="small"
            variant="outlined"
            margin="dense"
          />
          <TextField
            id="outlined-basic"
            label="Company"
            value={company}
            onChange={handleChangeCompany}
            size="small"
            variant="outlined"
            margin="dense"
          />
          <TextField
            id="outlined-basic"
            label="Language"
            value={language}
            onChange={handleChangeLanguage}
            size="small"
            variant="outlined"
            margin="dense"
          />
          <TextField
            id="outlined-basic"
            label="Genre"
            value={genre}
            onChange={handleChangeGenre}
            size="small"
            variant="outlined"
            margin="dense"
          />
          <TextField
            id="outlined-basic"
            label="Review"
            value={review}
            onChange={handleChangeReview}
            size="small"
            variant="outlined"
            margin="dense"
          />
          <TextField
            id="outlined-basic"
            label="ID"
            value={id}
            onChange={handleChangeId}
            size="small"
            variant="outlined"
            margin="dense"
          />

          <button onClick={handleSubmitTest}>Submit</button>
        </>
      ) : (
        <>
          <CardContent>
            <div className="card-info">
              <Typography variant="body2">Title: {title}</Typography>
              <Typography variant="body2">company: {company}</Typography>
              <Typography variant="body2">Language: {language}</Typography>
              <Typography variant="body2">Genre: {genre}</Typography>
              <Typography variant="body2">Review: {review}</Typography>
              <Typography variant="body2">ID: {id}</Typography>
            </div>
          </CardContent>
          <CardActions>
            <button onClick={handleShowForm}>Edit</button>
            <button onClick={handleDelete}>Delete</button>
          </CardActions>
        </>
      )}
    </Card>
  );
};

GameCard.propTypes = {
  game: PropTypes.shape({
    id: PropTypes.number,
    title: PropTypes.string,
    language: PropTypes.string,
    genre: PropTypes.string,
    company: PropTypes.string,
    review: PropTypes.string,
  }),
};
