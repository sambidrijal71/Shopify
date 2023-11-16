import { Box, AppBar, Typography } from '@mui/material';

const Footer = () => {
  const date = new Date().getFullYear();
  return (
    <Box sx={{ marginTop: 12 }}>
      <AppBar
        position='fixed'
        color='primary'
        style={{ top: 'auto', bottom: 0 }}
        sx={{
          display: 'flex',
          alignItems: 'center',
          justifyContent: 'center',
        }}
      >
        <Typography variant='h6' paddingY={2}>
          Shopify ©️All Rights Reserved©️ {date}
        </Typography>
      </AppBar>
    </Box>
  );
};
export default Footer;
