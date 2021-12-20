import * as React from 'react';
// import { useSelector } from 'react-redux';
import { styled } from '@mui/material/styles';
import Box from '@mui/material/Box';
import List from '@mui/material/List';
import ListItem from '@mui/material/ListItem';
import ListItemAvatar from '@mui/material/ListItemAvatar';
import ListItemText from '@mui/material/ListItemText';
import Avatar from '@mui/material/Avatar';
import IconButton from '@mui/material/IconButton';
import Grid from '@mui/material/Grid';
import DeleteIcon from '@mui/icons-material/Delete';
import EmailIcon from '@mui/icons-material/Email';
import CheckIcon from '@mui/icons-material/Check';
import InfoIcon from '@mui/icons-material/Info';
import { AdminPagination } from '../../Pagination/Pagination';
import { setInfo } from '../../../store/actions';
import { useDispatch } from 'react-redux';
// import { RootState } from '../../../store/reducers/rootReducer';

const applicationsArray = [
  {
    id: 1,
    isArchived: true,
    message: 'I think, I need help. Please, contact me as soon as possible!',
    email: 'fgnhfgxvcb@gmail.com',
    userName: 'Alex Pushkin',
    testResultsId: 7,
  },
  {
    id: 2,
    isArchived: true,
    message: 'I think, I need help. Please, contact me as soon as possible!',
    email: 'hjklnm287@gmail.com',
    userName: 'Ivan Petrov',
    testResultsId: 7,
  },
  {
    id: 3,
    isArchived: true,
    message: 'I think, I need help. Please, contact me as soon as possible!',
    email: 'gnbpok6@gmail.com',
    userName: 'Nick Armstrong',
    testResultsId: 7,
  },
];

const ListContainer = styled('div')(({ theme }) => ({
  backgroundColor: theme.palette.background.paper,
}));

export const RequestsList = () => {
  const dispatch = useDispatch();
  // const trainApps = useSelector(
  //   (state: RootState) => state.applications.trains,
  // );

  return (
    <Box sx={{ flexGrow: 1, width: '100%' }}>
      <Grid item md={12}>
        <ListContainer>
          <List dense={false}>
            {applicationsArray.map((application, index) => {
              return (
                <ListItem
                  key={application.id}
                  secondaryAction={
                    <>
                      <IconButton
                        onClick={() => dispatch(setInfo(application))}
                        edge="end"
                        aria-label="delete">
                        <InfoIcon />
                      </IconButton>
                      <IconButton edge="end" aria-label="delete">
                        <CheckIcon />
                      </IconButton>
                      <IconButton edge="end" aria-label="delete">
                        <DeleteIcon />
                      </IconButton>
                    </>
                  }>
                  <ListItemAvatar>
                    <Avatar>
                      <EmailIcon />
                    </Avatar>
                  </ListItemAvatar>
                  <ListItemText
                    primary={application.userName}
                    secondary={application.email}
                  />
                </ListItem>
              );
            })}
          </List>
        </ListContainer>
      </Grid>
      <AdminPagination />
    </Box>
  );
};
