import * as React from 'react';
import { DataGrid, GridColDef, GridRenderCellParams } from '@mui/x-data-grid';
import { Typography } from '@mui/material';
import { Link } from 'react-router-dom';

const columns: GridColDef[] = [
  { field: 'id', headerName: 'ID', width: 40 },
  {
    field: 'firstName',
    headerName: 'First name',
    width: 150,
    editable: true,
  },
  {
    field: 'lastName',
    headerName: 'Last name',
    width: 150,
    editable: true,
  },
  {
    field: 'age',
    headerName: 'Age',
    type: 'number',
    width: 60,
    editable: true,
  },
  {
    field: 'email',
    headerName: 'Email',
    width: 250,
    editable: true,
  },
  {
    field: 'state',
    headerName: 'Emotional state',
    width: 150,
    editable: true,
  },
  {
    field: 'testResults',
    headerName: 'Link to Test Results',
    description: 'This column has a value getter and is not sortable.',
    sortable: false,
    width: 160,
    renderCell: (params: GridRenderCellParams) => {
      return <Link to="home">Link</Link>;
    },
  },
];

const rows = [
  {
    id: 1,
    lastName: 'Snow',
    firstName: 'Jon',
    age: 35,
    email: '1234567890@gmail.com',
    state: 'Happy',
  },
  {
    id: 2,
    lastName: 'Lannister',
    firstName: 'Cersei',
    age: 42,
    email: '1234567890@gmail.com',
    state: 'Happy',
  },
  {
    id: 3,
    lastName: 'Lannister',
    firstName: 'Jaime',
    age: 45,
    email: '1234567890@gmail.com',
    state: 'Depressed',
  },
  {
    id: 4,
    lastName: 'Stark',
    firstName: 'Arya',
    age: 16,
    email: '1234567890@gmail.com',
    state: 'Happy',
  },
  {
    id: 5,
    lastName: 'Targaryen',
    firstName: 'Daenerys',
    age: null,
    email: '1234567890@gmail.com',
    state: 'Sad',
  },
  {
    id: 6,
    lastName: 'Melisandre',
    firstName: null,
    age: 150,
    email: '1234567890@gmail.com',
    state: 'Happy',
  },
  {
    id: 7,
    lastName: 'Clifford',
    firstName: 'Ferrara',
    age: 44,
    email: '1234567890@gmail.com',
    state: 'Happy',
  },
  {
    id: 8,
    lastName: 'Frances',
    firstName: 'Rossini',
    age: 36,
    email: '1234567890@gmail.com',
    state: 'Happy',
  },
  {
    id: 9,
    lastName: 'Roxie',
    firstName: 'Harvey',
    age: 65,
    email: '1234567890@gmail.com',
  },
];

export const UsersGrid = () => {
  return (
    <div style={{ height: 600, width: '100%' }}>
      <Typography sx={{ mt: 4, mb: 2 }} variant="h6" component="div">
        USERS
      </Typography>
      <DataGrid
        rows={rows}
        columns={columns}
        pageSize={10}
        rowsPerPageOptions={[10]}
        checkboxSelection
        disableSelectionOnClick
      />
    </div>
  );
};
