import * as React from 'react';
import List from '@mui/material/List';
import ListItemButton from '@mui/material/ListItemButton';
import ListItemIcon from '@mui/material/ListItemIcon';
import ListItemText from '@mui/material/ListItemText';
import Collapse from '@mui/material/Collapse';
import InboxIcon from '@mui/icons-material/MoveToInbox';
import WorkIcon from '@mui/icons-material/Work';
import ExpandLess from '@mui/icons-material/ExpandLess';
import ExpandMore from '@mui/icons-material/ExpandMore';
import AccessTimeIcon from '@mui/icons-material/AccessTime';
import Typography from '@mui/material/Typography';
import GroupIcon from '@mui/icons-material/Group';
import CheckCircleOutlineIcon from '@mui/icons-material/CheckCircleOutline';
import DeleteOutlineIcon from '@mui/icons-material/DeleteOutline';
import { Link } from 'react-router-dom';
import './AdminTabs.scss';

export const AdminTabs = () => {
  const [open, setOpen] = React.useState(true);

  const handleClick = () => {
    setOpen(!open);
  };

  return (
    <List
      sx={{
        width: '100%',
        maxWidth: 250,
        bgcolor: 'background.paper',
        borderRight: 1,
        borderColor: 'divider',
      }}
      component="nav"
      aria-labelledby="nested-list-subheader"
      subheader={
        <Typography sx={{ mt: 4, mb: 2 }} variant="h6" component="div">
          CATEGORIES
        </Typography>
      }>
      <Link className="tab-link" to="users">
        <ListItemButton>
          <ListItemIcon>
            <GroupIcon />
          </ListItemIcon>
          <ListItemText className="tab-link" primary="Users" />
        </ListItemButton>
      </Link>
      <Link className="tab-link" to="psychologists">
        <ListItemButton>
          <ListItemIcon>
            <WorkIcon />
          </ListItemIcon>
          <ListItemText primary="Psychologists" />
        </ListItemButton>
      </Link>
      <ListItemButton onClick={handleClick}>
        <ListItemIcon>
          <InboxIcon />
        </ListItemIcon>
        <ListItemText primary="Inbox requests" />
        {open ? <ExpandLess /> : <ExpandMore />}
      </ListItemButton>
      <Collapse in={open} timeout="auto" unmountOnExit>
        <List component="div" disablePadding>
          <Link className="tab-link" to="pending-requests">
            <ListItemButton sx={{ pl: 4 }}>
              <ListItemIcon>
                <AccessTimeIcon />
              </ListItemIcon>
              <ListItemText primary="Pending" />
            </ListItemButton>
          </Link>
          <Link className="tab-link" to="viewed-requests">
            <ListItemButton sx={{ pl: 4 }}>
              <ListItemIcon>
                <CheckCircleOutlineIcon />
              </ListItemIcon>
              <ListItemText primary="Viewed" />
            </ListItemButton>
          </Link>
          <Link className="tab-link" to="deleted-requests">
            <ListItemButton sx={{ pl: 4 }}>
              <ListItemIcon>
                <DeleteOutlineIcon />
              </ListItemIcon>
              <ListItemText primary="Deleted" />
            </ListItemButton>
          </Link>
        </List>
      </Collapse>
    </List>
  );
};
