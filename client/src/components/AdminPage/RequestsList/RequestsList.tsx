import * as React from 'react';
import { useSelector } from 'react-redux';
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
import { AdminPagination } from '../../Pagination/Pagination';
import { RootState } from '../../../store/reducers/rootReducer';

const generate = (element: React.ReactElement) => {
  return [0, 1, 2, 3, 4, 5, 6, 7, 8, 9].map((value) =>
    React.cloneElement(element, {
      key: value,
    }),
  );
};

const ListContainer = styled('div')(({ theme }) => ({
  backgroundColor: theme.palette.background.paper,
}));

export const RequestsList = () => {
  const applicationsState = useSelector(
    (state: RootState) => state.applications,
  );
  console.log(applicationsState);
  return (
    <Box sx={{ flexGrow: 1, width: '100%' }}>
      <Grid item md={12}>
        <ListContainer>
          <List dense={false}>
            {generate(
              <ListItem
                secondaryAction={
                  <>
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
                  primary={applicationsState.name}
                  secondary={applicationsState.email}
                />
              </ListItem>,
            )}
          </List>
        </ListContainer>
      </Grid>
      <AdminPagination />
    </Box>
  );
};
