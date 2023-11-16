import {
  TableContainer,
  Paper,
  Table,
  TableBody,
  TableRow,
  TableCell,
  Box,
} from '@mui/material';
import { useAppSelector } from '../../app/store/configureStore';
import { currencyConverter } from '../../app/utils/utils';

const BasketSummary = () => {
  const { basket } = useAppSelector((state) => state.basket);

  const subTotal = basket?.items.reduce(
    (sum, item) =>
      (item.quantity * (item.price * (100 - item.discountPercentage))) / 100 +
      sum,
    0
  );
  const totalQuantity = basket?.items.reduce(
    (sum, item) => sum + item.quantity,
    0
  );

  const deliveryFee = subTotal && subTotal <= 10000 ? 500 : 0;
  return (
    <Box marginTop={2} marginBottom={1}>
      <TableContainer component={Paper} variant={'outlined'}>
        <Table>
          <TableBody>
            <TableRow>
              <TableCell colSpan={2}>Total Items</TableCell>
              <TableCell align='right'>{totalQuantity || 0}</TableCell>
            </TableRow>
            <TableRow>
              <TableCell colSpan={2}>Sub Total</TableCell>
              <TableCell align='right'>
                ${(subTotal && currencyConverter(subTotal)) || '0.00'}
              </TableCell>
            </TableRow>
            <TableRow>
              <TableCell colSpan={2}>Delivery Fee*</TableCell>
              <TableCell align='right'>
                ${currencyConverter(deliveryFee)}
              </TableCell>
            </TableRow>
            <TableRow>
              <TableCell colSpan={2}>Total</TableCell>
              <TableCell align='right'>
                $
                {(subTotal && currencyConverter(subTotal + deliveryFee)) ||
                  '0.00'}
              </TableCell>
            </TableRow>
            <TableRow>
              <TableCell>
                <span style={{ fontStyle: 'italic' }}>
                  *Orders over $100 qualify for free delivery
                </span>
              </TableCell>
            </TableRow>
          </TableBody>
        </Table>
      </TableContainer>
    </Box>
  );
};

export default BasketSummary;
