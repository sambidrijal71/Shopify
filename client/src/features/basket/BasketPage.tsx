import {
  TableContainer,
  Paper,
  Table,
  TableHead,
  TableRow,
  TableCell,
  TableBody,
  Box,
  Typography,
  Grid,
  Button,
} from '@mui/material';
import { useAppDispatch, useAppSelector } from '../../app/store/configureStore';
import { LoadingButton } from '@mui/lab';
import { Add, Delete, Remove } from '@mui/icons-material';
import { addBasketItemsAsync, removeBasketItemsAsync } from './basketSlice';
import { currencyConverter } from '../../app/utils/utils';
import { NavLink } from 'react-router-dom';
import BasketSummary from './BasketSummary';

const BasketPage = () => {
  const { basket, status } = useAppSelector((state) => state.basket);
  const dispatch = useAppDispatch();
  return (
    <>
      <TableContainer component={Paper}>
        <Table aria-label='products-description'>
          <TableHead>
            <TableRow>
              <TableCell align='center' style={{ width: 420 }}>
                Name
              </TableCell>
              <TableCell align='center'>Price</TableCell>
              <TableCell align='center'>Quantity</TableCell>
              <TableCell align='center'>Sub Total</TableCell>
              <TableCell align='center'>Action</TableCell>
            </TableRow>
          </TableHead>
          <TableBody>
            {basket?.items.map((item) => (
              <TableRow key={item.name}>
                <TableCell align='left' style={{ width: 420 }}>
                  <Box display='flex' alignItems='center'>
                    <img src={item.thumbnail} alt={item.name} width={50} />
                    <Typography
                      variant='body2'
                      marginLeft={8}
                      component={NavLink}
                      to={`/catalog/${item.productId}`}
                      sx={{ textDecoration: 'none', color: 'inherit' }}
                    >
                      {item.name}
                    </Typography>
                  </Box>
                </TableCell>
                <TableCell align='center'>
                  <Box
                    display='flex'
                    justifyContent='space-around'
                    alignItems='center'
                  >
                    <Typography
                      variant='body2'
                      sx={{ textDecoration: 'line-through' }}
                    >
                      ${currencyConverter(item.price)}
                    </Typography>
                    <Typography variant='body2'>
                      $
                      {currencyConverter(
                        (item.price * (100 - item.discountPercentage)) / 100
                      )}
                    </Typography>
                  </Box>
                </TableCell>
                <TableCell align='center'>
                  <LoadingButton
                    loading={
                      status === 'pendingRemoveItem' + item.productId + 'rem'
                    }
                    color='warning'
                    onClick={() =>
                      dispatch(
                        removeBasketItemsAsync({
                          productId: item.productId,
                          quantity: 1,
                          name: 'rem',
                        })
                      )
                    }
                  >
                    <Remove />
                  </LoadingButton>
                  {item.quantity}
                  <LoadingButton
                    loading={status === 'pendingAddItem' + item.productId}
                    color='success'
                    onClick={() => {
                      dispatch(
                        addBasketItemsAsync({
                          productId: item.productId,
                          quantity: 1,
                        })
                      );
                    }}
                  >
                    <Add />
                  </LoadingButton>
                </TableCell>
                <TableCell align='center'>
                  $
                  {currencyConverter(
                    (item.quantity *
                      (item.price * (100 - item.discountPercentage))) /
                      100
                  )}
                </TableCell>
                <TableCell align='center'>
                  <LoadingButton
                    loading={
                      status === 'pendingRemoveItem' + item.productId + 'del'
                    }
                    color='error'
                    onClick={() =>
                      dispatch(
                        removeBasketItemsAsync({
                          productId: item.productId,
                          quantity: item.quantity,
                          name: 'del',
                        })
                      )
                    }
                  >
                    <Delete />
                  </LoadingButton>
                </TableCell>
              </TableRow>
            ))}
          </TableBody>
        </Table>
      </TableContainer>
      <Grid container spacing={6}>
        <Grid item xs={6} />
        <Grid item xs={6}>
          <BasketSummary />
          <Button
            size='large'
            variant='outlined'
            component={NavLink}
            to='/checkout'
          >
            Checkout
          </Button>
        </Grid>
      </Grid>
    </>
  );
};

export default BasketPage;
