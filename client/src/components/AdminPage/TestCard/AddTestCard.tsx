import * as React from 'react';
import Card from '@mui/material/Card';
import './TestCard.scss';
import { useState } from 'react';
import { useDispatch } from 'react-redux';
import { TextField } from '@mui/material';
import AddIcon from '@mui/icons-material/Add';
import { testsPutRequest } from '../../../store/actions';

export const AddTestCard = () => {
  const dispatch = useDispatch();
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
    dispatch(testsPutRequest(body));
  };

  return (
    <Card sx={{ width: 250, margin: 1 }}>
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
          <button className="add-button" onClick={handleShowForm}>
            <AddIcon sx={{ fontSize: 80 }} />
          </button>
        </>
      )}
    </Card>
  );
};
