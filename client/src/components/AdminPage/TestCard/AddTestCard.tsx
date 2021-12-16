import * as React from 'react';
import Card from '@mui/material/Card';
import './TestCard.scss';
import { useState } from 'react';
import { TextField } from '@mui/material';
import axios from 'axios';

export const AddTestCard = () => {
  const [showForm, setShowForm] = useState(false);
  const [title, setTitle] = useState('');
  const [id, setId] = useState('');
  const [type, setType] = useState('');

  const body = {
    id: Number.parseInt(id),
    title: title,
    typeOfTest: Number.parseInt(type),
  };

  const handleShowForm = () => {
    setShowForm(!showForm);
    console.log(showForm);
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

  const handleSubmitTest = () => {
    handleShowForm();
    console.log('SUBMIT');
    axios
      .post('https://emotionalhelptest.azurewebsites.net/api/Test', body)
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
          <button onClick={handleShowForm}>Add</button>
        </>
      )}
    </Card>
  );
};
