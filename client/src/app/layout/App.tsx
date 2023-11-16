import {
  Container,
  CssBaseline,
  ThemeProvider,
  createTheme,
} from '@mui/material';
import Header from './Header';
import Footer from './Footer';
import { useEffect, useState } from 'react';
import { Outlet } from 'react-router-dom';
import { ToastContainer } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';
import { useAppDispatch } from '../store/configureStore';
import { setBasket } from '../../features/basket/basketSlice';
import { getCookie } from '../utils/utils';
import agent from '../../api/agent';
import LoadingComponent from '../components/LoadingComponent';

const App = () => {
  const [darkMode, setDarkMode] = useState<boolean>(false);
  const dispatch = useAppDispatch();
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    setLoading(true);
    const buyerId = getCookie('BuyerId');
    if (buyerId) {
      agent.Basket.get()
        .then((basket) => dispatch(setBasket(basket)))
        .catch((error) => console.log(error))
        .finally(() => setLoading(false));
    } else {
      setLoading(false);
    }
  }, [dispatch]);
  const paletteTheme = darkMode ? 'dark' : 'light';

  const darkTheme = createTheme({
    palette: {
      primary: {
        light: !darkMode ? '#212121' : '#e5e8e8',
        main: !darkMode ? '#60809f' : '#8d9797',
        dark: !darkMode ? '#233c65' : '#1ECBE1',
        contrastText: '#fff',
      },
      secondary: {
        light: !darkMode ? '#c3e0e5' : '#bbc4c2',
        main: !darkMode ? '#acc1e2' : '#eeeeee',
        dark: !darkMode ? '#3d5f7f' : '#33c3cc',
        contrastText: '#000',
      },
      mode: paletteTheme,
      background: {
        paper: darkMode ? '#212121' : '#eeeeee',
      },
    },
  });

  const handleThemeChange: () => void = () => {
    setDarkMode(!darkMode);
  };
  if (loading) return <LoadingComponent message='Initializing App...' />;
  return (
    <ThemeProvider theme={darkTheme}>
      <ToastContainer
        position='bottom-right'
        autoClose={4000}
        hideProgressBar={false}
        newestOnTop={false}
        closeOnClick
        rtl={false}
        pauseOnFocusLoss
        draggable
        pauseOnHover
        theme={darkMode ? 'dark' : 'light'}
      />
      <CssBaseline />
      <Header theme={darkMode} handleThemeChange={handleThemeChange} />
      <Container>
        <Outlet />
      </Container>
      <Footer />
    </ThemeProvider>
  );
};

export default App;
