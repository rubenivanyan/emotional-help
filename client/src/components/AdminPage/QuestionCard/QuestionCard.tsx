import React, { useState } from 'react';
import Card from '@mui/material/Card';
import CardActions from '@mui/material/CardActions';
import CardContent from '@mui/material/CardContent';
import Typography from '@mui/material/Typography';
import './QuestionCard.scss';
import { TextField } from '@mui/material';
import PropTypes from 'prop-types';
import { useDispatch } from 'react-redux';
import {
  questionsDeleteRequest,
  questionsPutRequest,
} from '../../../store/actions';

export const QuestionCard = (props) => {
  const [showForm, setShowForm] = useState(false);
  const [formulation, setFormulation] = useState(props.question.formulation);
  const [url, setUrl] = useState(props.question.imageUrl);
  const [id, setId] = useState(props.question.id);

  const dispatch = useDispatch();

  const body = {
    imageUrl: url,
    formulation: formulation,
    id: Number.parseInt(id),
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

  const handleSubmitQuestion = () => {
    handleShowForm();
    console.log('SUBMIT');
    dispatch(questionsPutRequest(body));
  };

  const handleDelete = () => {
    dispatch(questionsDeleteRequest(body));
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

          <button onClick={handleSubmitQuestion}>Submit</button>
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
