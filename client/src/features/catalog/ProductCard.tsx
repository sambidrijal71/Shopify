import {
  Card,
  CardMedia,
  CardContent,
  Typography,
  CardActions,
  Button,
  Avatar,
  CardHeader,
} from '@mui/material';
import { Product } from '../../app/models/Product';
import { useNavigate } from 'react-router-dom';
import { LoadingButton } from '@mui/lab';
import { useAppDispatch, useAppSelector } from '../../app/store/configureStore';
import { addBasketItemsAsync } from '../basket/basketSlice';
import { currencyConverter } from '../../app/utils/utils';

interface Props {
  product: Product;
}
const ProductCard = ({ product }: Props) => {
  const { status } = useAppSelector((state) => state.basket);
  const dispatch = useAppDispatch();
  const navigate = useNavigate();
  return (
    <Card sx={{}}>
      <CardHeader
        avatar={
          <Avatar
            sx={{ color: 'secondary.main', backgroundColor: 'primary.dark' }}
            aria-label={product.name}
          >
            {product.name.charAt(0).toUpperCase()}
          </Avatar>
        }
        title={product.name.split(/\s+/).slice(0, 3).join(' ')}
        titleTypographyProps={{
          sx: {
            fontSize: '1rem',
            fontWeight: 'bold',
            color: 'primary.light',
          },
        }}
      />
      <CardMedia
        sx={{ height: 140, backgroundSize: 'contain' }}
        image={product.thumbnail}
        title={product.name}
      />
      <CardContent>
        <Typography
          gutterBottom
          variant='h6'
          component='div'
          sx={{
            display: 'flex',
            justifyContent: 'space-between',
            color: 'primary.dark',
          }}
        >
          <span style={{ textDecoration: 'line-through' }}>
            ${currencyConverter(product.price)}
          </span>
          <span>
            $
            {currencyConverter(
              (product.price * (100 - product.discountPercentage)) / 100
            )}
          </span>
        </Typography>
        <Typography variant='body2' color='text.secondary'>
          {product.category.charAt(0).toUpperCase() + product.category.slice(1)}{' '}
          / {product.brand.split(/\s+/).slice(0, 2).join(' ')}
        </Typography>
      </CardContent>
      <CardActions sx={{ display: 'flex', justifyContent: 'space-around' }}>
        <Button
          size='medium'
          sx={{ color: 'secondary.dark' }}
          onClick={() => navigate(`/catalog/${product.id}`)}
        >
          View
        </Button>
        <LoadingButton
          size='medium'
          sx={{ color: 'secondary.dark' }}
          loading={status.includes('pendingAddItem' + product.id)}
          onClick={() =>
            dispatch(
              addBasketItemsAsync({ productId: product.id, quantity: 1 })
            )
          }
        >
          Add To Cart
        </LoadingButton>
      </CardActions>
    </Card>
  );
};

export default ProductCard;
