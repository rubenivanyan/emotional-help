import React, { useState } from 'react';
import Card from '@mui/material/Card';
import './QuestionCard.scss';
// import { useDispatch } from 'react-redux';
import { TextField } from '@mui/material';
import axios from 'axios';
import AddIcon from '@mui/icons-material/Add';

export const AddQuestionCard = () => {
  // const dispatch = useDispatch();
  const [showForm, setShowForm] = useState(false);
  const [formulation, setFormulation] = useState('');
  const [url, setUrl] = useState('');
  const [id, setId] = useState('');

  const body = {
    imageUrl: url,
    formulation: formulation,
    id: Number.parseInt(id),
  };

  const handleShowForm = () => {
    setShowForm(!showForm);
    console.log(showForm);
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

  return (
    <Card sx={{ width: 250, margin: 1, minHeight: 135 }}>
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
          <button className="add-button" onClick={handleShowForm}>
            <AddIcon sx={{ fontSize: 80 }} />
          </button>
        </>
      )}
    </Card>
  );
};
