import * as React from 'react';
import Card from '@mui/material/Card';
import CardActions from '@mui/material/CardActions';
import CardContent from '@mui/material/CardContent';
import Typography from '@mui/material/Typography';
import './QuestionCard.scss';
import { useState } from 'react';
import { TextField } from '@mui/material';
import PropTypes from 'prop-types';
import axios from 'axios';

export const QuestionCard = (props) => {
  const [showForm, setShowForm] = useState(false);
  const [formulation, setFormulation] = useState(props.question.formulation);
  const [url, setUrl] = useState(props.question.imageUrl);
  const [id, setId] = useState(props.question.id);

  const body = {
    imageUrl: url,
    formulation: formulation,
    id: id,
  };

  const handleChangeFormulation = (
    event: React.ChangeEvent<HTMLInputElement>,
  ) => {
    setFormulation(event.target.value);
  };
  const handleChangeId = (event: React.ChangeEvent<HTMLInputElement>) => {
    setId(event.target.value);
  };

  const handleChangeUrl = (event: React.ChangeEvent<HTMLInputElement>) => {
    setUrl(event.target.value);
  };

  const handleShowForm = () => {
    setShowForm(!showForm);
    console.log(showForm);
  };

  const handleSubmitTest = () => {
    handleShowForm();
    console.log('SUBMIT');
    axios
      .put('https://emotionalhelptest.azurewebsites.net/api/Question', body)
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
      .delete(`https://emotionalhelptest.azurewebsites.net/api/Question/${id}`)
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
    <Card sx={{ width: 250, margin: 1 }}>
      {showForm ? (
        <>
          <TextField
            id="outlined-basic"
            label="Question"
            value={formulation}
            onChange={handleChangeFormulation}
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
          <TextField
            id="outlined-basic"
            label="Type of test"
            value={url}
            onChange={handleChangeUrl}
            size="small"
            variant="outlined"
            margin="dense"
          />

          <button onClick={handleSubmitTest}>Submit</button>
        </>
      ) : (
        <>
          {' '}
          <CardContent>
            <div className="card-info">
              <Typography variant="body2">Question: {formulation}</Typography>
              <Typography variant="body2">ID: {id}</Typography>
              <Typography variant="body2">Image URL: {url}</Typography>
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

QuestionCard.propTypes = {
  question: PropTypes.shape({
    formulation: PropTypes.string,
    id: PropTypes.number,
    variants: PropTypes.array,
    imageUrl: PropTypes.string,
  }),
};
