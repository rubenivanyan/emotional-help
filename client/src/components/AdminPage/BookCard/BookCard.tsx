import * as React from 'react';
import Card from '@mui/material/Card';
import CardActions from '@mui/material/CardActions';
import CardContent from '@mui/material/CardContent';
import Typography from '@mui/material/Typography';
import './BookCard.scss';
import { useState } from 'react';
import { TextField } from '@mui/material';
import PropTypes from 'prop-types';
import axios from 'axios';

export const BookCard = (props) => {
  const [showForm, setShowForm] = useState(false);
  const [title, setTitle] = useState(props.book.title);
  const [id, setId] = useState(props.book.id);
  const [language, setLanguage] = useState(props.book.language);
  const [genre, setGenre] = useState(props.book.genre);
  const [author, setAuthor] = useState(props.book.author);

  const body = {
    id: id,
    title: title,
    language: language,
    genre: genre,
    author: author,
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
  const handleChangeAuthor = (event: React.ChangeEvent<HTMLInputElement>) => {
    setAuthor(event.target.value);
  };

  const handleShowForm = () => {
    setShowForm(!showForm);
    console.log(showForm);
  };

  const handleSubmitTest = () => {
    handleShowForm();
    console.log('SUBMIT');
    axios
      .put('https://emotionalhelptest.azurewebsites.net/api/Film', body)
      .then((response) => {
        console.log(response);
      })
      .catch((error) => {
        console.log(body);
        console.log(error);
      });
    setTimeout(() => {
      window.location.reload();
    }, 1000);
  };

  const handleDelete = () => {
    axios
      .delete(`https://emotionalhelptest.azurewebsites.net/api/Book/${id}`)
      .then((response) => {
        console.log(response);
      })
      .catch((error) => {
        console.log(error);
      });
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
            label="Author"
            value={author}
            onChange={handleChangeAuthor}
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
              <Typography variant="body2">Author: {author}</Typography>
              <Typography variant="body2">Language: {language}</Typography>
              <Typography variant="body2">Genre: {genre}</Typography>
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

BookCard.propTypes = {
  book: PropTypes.shape({
    id: PropTypes.number,
    title: PropTypes.string,
    language: PropTypes.string,
    genre: PropTypes.string,
    author: PropTypes.string,
  }),
};
