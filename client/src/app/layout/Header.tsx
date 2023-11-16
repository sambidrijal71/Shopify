import { ShoppingCart } from '@mui/icons-material';
import {
  Box,
  AppBar,
  Toolbar,
  Switch,
  List,
  Badge,
  Typography,
} from '@mui/material';
import { NavLink } from 'react-router-dom';
import { useAppSelector } from '../store/configureStore';

interface Props {
  theme: boolean;
  handleThemeChange: () => void;
}
const midLink = [
  { name: 'catalog', path: '/catalog' },
  { name: 'about us', path: '/about-us' },
  { name: 'contact us', path: '/contact-us' },
];
const rightLink = [
  { name: 'login', path: '/login' },
  { name: 'register', path: '/register' },
];

const navStyle = {
  marginX: 2,
  textDecoration: 'none',
  textTransform: 'uppercase',
  color: 'inherit',
  fontSize: '1.2rem',
  '&:hover': { color: 'grey:500' },
  '&.active': { color: 'text.secondary' },
};
const Header = ({ theme, handleThemeChange }: Props) => {
  const { basket } = useAppSelector((state) => state.basket);
  const totalQuantity = basket?.items.reduce(
    (sum, item) => item.quantity + sum,
    0
  );
  return (
    <AppBar position='sticky' sx={{ mb: 4 }}>
      <Toolbar
        sx={{
          display: 'flex',
          justifyContent: 'space-between',
          alignItems: 'center',
        }}
      >
        <Box
          sx={{
            display: 'flex',
            alignItems: 'center',
          }}
        >
          <Typography
            component={NavLink}
            to='/home'
            sx={{
              fontWeight: 'bold',
              color: 'inherit',
              textDecoration: 'none',
              fontSize: '1.4rem',
            }}
          >
            SHOPIFY
          </Typography>
          <Switch checked={theme} onChange={handleThemeChange} />
        </Box>
        <Box
          sx={{
            display: 'flex',
            alignItems: 'center',
          }}
        >
          {midLink.map((link) => (
            <List
              key={link.name}
              component={NavLink}
              to={link.path}
              sx={navStyle}
            >
              {link.name}
            </List>
          ))}
        </Box>

        <Box
          sx={{
            display: 'flex',
            justifyContent: 'space-between',
            alignItems: 'center',
          }}
        >
          <List
            component={NavLink}
            to={'/basket'}
            sx={{
              textDecoration: 'none',
              textTransform: 'uppercase',
              color: 'inherit',
              fontSize: '1.2rem',
            }}
          >
            <Badge
              color='secondary'
              badgeContent={totalQuantity}
              sx={{ marginRight: '12px' }}
            >
              <ShoppingCart />
            </Badge>
          </List>

          <Box
            sx={{
              display: 'flex',
              justifyContent: 'space-between',
              alignItems: 'center',
            }}
          >
            {rightLink.map((link) => (
              <List
                component={NavLink}
                to={link.path}
                key={link.name}
                sx={navStyle}
              >
                {link.name}
              </List>
            ))}
          </Box>
        </Box>
      </Toolbar>
    </AppBar>
  );
};

export default Header;
