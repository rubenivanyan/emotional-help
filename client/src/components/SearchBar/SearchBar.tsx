import * as React from 'react';
import Paper from '@mui/material/Paper';
import InputBase from '@mui/material/InputBase';
import IconButton from '@mui/material/IconButton';
import SearchIcon from '@mui/icons-material/Search';
import './SearchBar.scss';

export const SearchBar = () => {
  return (
    <Paper
      className="search-bar-container"
      component="form"
      sx={{display: 'flex', alignItems: 'center', width: 200}}>
      <InputBase
        sx={{ml: 1, flex: 1}}
        placeholder="Search"
        inputProps={{'aria-label': 'search'}}
      />
      <IconButton type="submit" sx={{p: '10px'}} aria-label="search">
        <SearchIcon />
      </IconButton>
    </Paper>
  );
};
