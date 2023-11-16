import { Navigate, createBrowserRouter } from 'react-router-dom';
import App from '../layout/App';
import Catalog from '../../features/catalog/Catalog';
import HomePage from '../../features/home/HomePage';
import AboutUs from '../../features/about/AboutUs';
import ProductDetails from '../../features/catalog/ProductDetails';
import ContactUs from '../../features/contact/ContactUs';
import NotFound from '../components/NotFound';
import BasketPage from '../../features/basket/BasketPage';
import LoginPage from '../../features/login/LoginPage';
import RegisterPage from '../../features/register/RegisterPage';
import ServerError from '../components/ServerError';
import CheckoutPage from '../../features/checkout/CheckoutPage';

const router = createBrowserRouter([
  {
    path: '/',
    element: <App />,
    children: [
      { path: '/catalog', element: <Catalog /> },
      { path: '/home', element: <HomePage /> },
      { path: '/catalog/:id', element: <ProductDetails /> },
      { path: '/about-us', element: <AboutUs /> },
      { path: '/contact-us', element: <ContactUs /> },
      { path: '/login', element: <LoginPage /> },
      { path: '/checkout', element: <CheckoutPage /> },
      { path: 'server-error', element: <ServerError /> },
      { path: '/register', element: <RegisterPage /> },
      { path: '/basket', element: <BasketPage /> },
      { path: 'not-found', element: <NotFound message='' /> },
      { path: '*', element: <Navigate replace to='/not-found' /> },
    ],
  },
]);

export default router;
