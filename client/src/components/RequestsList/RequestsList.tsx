import * as React from 'react';
import {styled} from '@mui/material/styles';
import Box from '@mui/material/Box';
import List from '@mui/material/List';
import ListItem from '@mui/material/ListItem';
import ListItemAvatar from '@mui/material/ListItemAvatar';
import ListItemText from '@mui/material/ListItemText';
import Avatar from '@mui/material/Avatar';
import IconButton from '@mui/material/IconButton';
import Grid from '@mui/material/Grid';
import Typography from '@mui/material/Typography';
import DeleteIcon from '@mui/icons-material/Delete';
import EmailIcon from '@mui/icons-material/Email';
import CheckIcon from '@mui/icons-material/Check';
import {AdminPagination} from '../../components/Pagination/Pagination';

const generate = (element: React.ReactElement) => {
  return [0, 1, 2, 3, 4, 5, 6, 7, 8, 9].map((value) =>
    React.cloneElement(element, {
      key: value,
    }),
  );
};

const ListContainer = styled('div')(({theme}) => ({
  backgroundColor: theme.palette.background.paper,
}));

export const RequestsList = () => {
  return (
    <Box sx={{flexGrow: 1, minWidth: 900, width: '50%'}}>
      <Grid item md={12}>
        <Typography sx={{mt: 4, mb: 2}} variant="h6" component="div">
          REQUESTS
        </Typography>
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
                  primary="Single-line item"
                  secondary="Secondary text"
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
