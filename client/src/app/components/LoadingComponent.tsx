import { Box, CircularProgress, Typography } from '@mui/material';

interface Props {
  message: string;
}
const LoadingComponent = ({ message }: Props) => {
  return (
    <div>
      <Box
        sx={{
          display: 'flex',
          flexDirection: 'column',
          justifyContent: 'center',
          alignItems: 'center',
          height: '90vh',
        }}
      >
        <CircularProgress />
        <Typography variant='h4' marginTop={8}>
          {message || 'Loading, please wait!!!'}
        </Typography>
      </Box>
    </div>
  );
};

export default LoadingComponent;
