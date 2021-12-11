import * as React from 'react';
import Card from '@mui/material/Card';
import CardActions from '@mui/material/CardActions';
import CardContent from '@mui/material/CardContent';
import Button from '@mui/material/Button';
import Typography from '@mui/material/Typography';
import Avatar from '@mui/material/Avatar';
import './UserCard.scss';

export const UserCard = () => {
  return (
    <Card sx={{width: 400}}>
      <CardContent>
        <div className="user-avatar-name">
          <Avatar
            alt="John Krasinski"
            src="/static/images/avatar/1.jpg"
            sx={{width: 56, height: 56}}
          />
          <Typography sx={{mb: 1.5}} color="text.secondary">
            John Krasinski
          </Typography>
        </div>
        <div className="card-info">
          <Typography variant="body2">Email: asde6e685679v@dot.com</Typography>
          <Typography variant="body2">Emotional state: Depressed</Typography>
          <Typography variant="body2">Last seen: 12.12.2021</Typography>
          <Typography variant="body2">Therapist: Feelgood, M.D.</Typography>
        </div>
      </CardContent>
      <CardActions>
        <Button size="small">View Profile</Button>
      </CardActions>
    </Card>
  );
};
