import * as React from 'react';
import Card from '@mui/material/Card';
import CardActions from '@mui/material/CardActions';
import CardContent from '@mui/material/CardContent';
import Typography from '@mui/material/Typography';
import './TestCard.scss';
import { useState } from 'react';
import { TextField } from '@mui/material';
import PropTypes from 'prop-types';
import axios from 'axios';
import { useNavigate } from 'react-router-dom';

export const TestCard = (props) => {
  const navigate = useNavigate();
  const [showForm, setShowForm] = useState(false);
  const [title, setTitle] = useState(props.test.title);
  const [id, setId] = useState(props.test.id);
  const [type, setType] = useState(props.test.typeOfTest);

  const body = {
    id: id,
    title: title,
    typeOfTest: type,
  };

  const handleChangeName = (event: React.ChangeEvent<HTMLInputElement>) => {
    setTitle(event.target.value);
  };
  const handleChangeId = (event: React.ChangeEvent<HTMLInputElement>) => {
    setId(event.target.value);
  };
  const handleChangeType = (event: React.ChangeEvent<HTMLInputElement>) => {
    setType(event.target.value);
  };

  const handleShowForm = () => {
    setShowForm(!showForm);
    console.log(showForm);
  };

  const handleSubmitTest = () => {
    handleShowForm();
    console.log('SUBMIT');
    axios
      .put('https://emotionalhelptest.azurewebsites.net/api/Test', body)
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

  const handleViewQuestions = () => {
    navigate(`/admin/questions/${id}`);
  };
  const handleDelete = () => {
    axios
      .delete(`https://emotionalhelptest.azurewebsites.net/api/Test/${id}`)
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
    <Card sx={{ width: 300, margin: 1 }}>
      {showForm ? (
        <>
          <TextField
            id="outlined-basic"
            label="Title"
            value={title}
            onChange={handleChangeName}
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
            value={type}
            onChange={handleChangeType}
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
              <Typography variant="body2">TITLE: {title}</Typography>
              <Typography variant="body2">ID: {id}</Typography>
              <Typography variant="body2">Type of test: {type}</Typography>
            </div>
          </CardContent>
          <CardActions>
            <button onClick={handleViewQuestions}>View questions</button>
            <button onClick={handleShowForm}>Edit</button>
            <button onClick={handleDelete}>Delete</button>
          </CardActions>
        </>
      )}
    </Card>
  );
};

TestCard.propTypes = {
  test: PropTypes.shape({
    title: PropTypes.string,
    id: PropTypes.number,
    typeOfTest: PropTypes.number,
  }),
};
