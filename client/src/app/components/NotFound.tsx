import { Box, Button, Paper, Typography } from '@mui/material';
import { NavLink, useLocation } from 'react-router-dom';

interface Props {
  message: string;
}
const NotFound = ({ message }: Props) => {
  const { state } = useLocation();
  console.log(state);
  const NotFoundError = state
    ? state.error.title
    : 'OOPS, Could not find what you are looking for!!!!';
  return (
    <Box
      sx={{
        display: 'flex',
        justifyContent: 'center',
        alignItems: 'center',
        height: '78vh',
        flexDirection: 'column',
      }}
    >
      <Paper
        elevation={5}
        sx={{ height: '30vh', display: 'flex', alignItems: 'center' }}
      >
        <Typography variant='h3' sx={{ padding: 8 }}>
          {message || NotFoundError}
        </Typography>
      </Paper>
      <Button
        variant='outlined'
        size='large'
        component={NavLink}
        to='/catalog'
        color='success'
        sx={{ marginTop: 8 }}
      >
        Go back to Catalog
      </Button>
    </Box>
  );
};

export default NotFound;
