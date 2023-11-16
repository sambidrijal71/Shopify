import { useEffect, useState } from 'react';
import { useParams } from 'react-router-dom';
import LoadingComponent from '../../app/components/LoadingComponent';
import {
  Box,
  Button,
  Dialog,
  DialogContent,
  DialogContentText,
  DialogTitle,
  Divider,
  Grid,
  Paper,
  Rating,
  Table,
  TableCell,
  TableContainer,
  TableHead,
  TableRow,
  TextField,
  Typography,
} from '@mui/material';
import { Carousel } from 'react-responsive-carousel';
import 'react-responsive-carousel/lib/styles/carousel.min.css';
import { LoadingButton } from '@mui/lab';
import { useAppDispatch, useAppSelector } from '../../app/store/configureStore';
import {
  addBasketItemsAsync,
  removeBasketItemsAsync,
} from '../basket/basketSlice';
import { currencyConverter } from '../../app/utils/utils';
import { fetchProductAsync, productSelector } from './catalogSlice';

const ProductDetails = () => {
  const { id } = useParams();
  const [open, setOpen] = useState(false);
  const [quantity, setQuantity] = useState(0);
  const { basket, status } = useAppSelector((state) => state.basket);
  const dispatch = useAppDispatch();
  const { status: productStatus } = useAppSelector((state) => state.catalog);
  const product = useAppSelector((state) =>
    productSelector.selectById(state, id!)
  );
  const item = basket?.items.find((i) => i.productId === product?.id);

  useEffect(() => {
    if (!product && id) {
      dispatch(fetchProductAsync(parseInt(id)));
    }
  }, [id, product, dispatch]);
  useEffect(() => {
    if (item) setQuantity(item.quantity);
  }, [item]);

  const handleOpenImage = () => {
    setOpen(true);
  };

  const handleCloseImage = () => {
    setOpen(false);
  };

  const handleChangeQuantity = (
    e: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement>
  ) => {
    e.preventDefault();
    if (parseInt(e.currentTarget.value) >= 0) {
      setQuantity(parseInt(e.target.value));
    }
  };
  const handleUpdateQuantity = () => {
    if (!item || item?.quantity < quantity) {
      const updatedQuantity = item ? quantity - item?.quantity : quantity;
      dispatch(
        addBasketItemsAsync({
          productId: parseInt(id!),
          quantity: updatedQuantity,
        })
      );
    } else {
      const updatedQuantity = item?.quantity - quantity;
      dispatch(
        removeBasketItemsAsync({
          productId: parseInt(id!),
          quantity: updatedQuantity,
          name: '',
        })
      );
    }
  };

  if (productStatus.includes('pendingFetchProduct') || !product)
    return <LoadingComponent message='Loading Product....' />;

  return (
    <>
      <Grid container spacing={6} display={'flex'} alignItems={'center'}>
        <Grid item xs={6}>
          <Box>
            <Button onClick={handleOpenImage}>
              <img
                src={product.thumbnail}
                alt={product.name}
                style={{ height: '100%' }}
              />
            </Button>
            <Dialog open={open} onClose={handleCloseImage}>
              <DialogTitle>{product.name}</DialogTitle>
              <DialogContent>
                <DialogContentText>
                  <Carousel infiniteLoop autoPlay showArrows={true}>
                    {product.images.map((image) => (
                      <img
                        key={product.name}
                        src={image}
                        style={{ maxHeight: '320px' }}
                      />
                    ))}
                  </Carousel>
                </DialogContentText>
              </DialogContent>
            </Dialog>
          </Box>
        </Grid>
        <Grid item xs={6}>
          <Box display={'flex'} justifyContent={'center'}>
            <Typography variant='h5'>{product.name}</Typography>
          </Box>
          <Divider
            sx={{ margin: 2, borderWidth: 2, borderColor: 'primary.dark' }}
          />
          <TableContainer component={Paper}>
            <Table aria-label='simple table'>
              <TableHead>
                <TableRow>
                  <TableCell align='left'>Description</TableCell>
                  <TableCell align='left'>{product.description}</TableCell>
                </TableRow>

                <TableRow>
                  <TableCell align='left'>Price</TableCell>
                  <TableCell align='left' sx={{ display: 'flex' }}>
                    <Typography
                      sx={{ textDecoration: 'line-through', marginRight: 6 }}
                    >
                      ${currencyConverter(product.price)}
                    </Typography>
                    <Typography>
                      $
                      {currencyConverter(
                        (product.price * (100 - product.discountPercentage)) /
                          100
                      )}
                    </Typography>
                  </TableCell>
                </TableRow>
                <TableRow>
                  <TableCell align='left'>Rating</TableCell>

                  <TableCell align='left'>
                    <Box
                      display={'flex'}
                      justifyContent={'flex-start'}
                      alignItems={'center'}
                    >
                      <Rating
                        name='read-only'
                        value={product.rating}
                        readOnly
                        sx={{ marginRight: 4 }}
                      />
                      {product.rating}
                    </Box>
                  </TableCell>
                </TableRow>

                <TableRow>
                  <TableCell align='left'>Category</TableCell>
                  <TableCell align='left'>{product.category}</TableCell>
                </TableRow>

                <TableRow>
                  <TableCell align='left'>Brand</TableCell>
                  <TableCell align='left'>{product.brand}</TableCell>
                </TableRow>
              </TableHead>
            </Table>
          </TableContainer>
        </Grid>
      </Grid>
      <Grid container columnSpacing={10}>
        <Grid item xs={6} />
        <Grid item xs={6}>
          <Box display={'flex'} alignItems={'center'} marginTop={4}>
            <TextField
              id='update-quantity'
              label={!item ? 'Add To Cart' : 'Update Quantity'}
              sx={{ color: 'secondary.dark' }}
              type='number'
              value={quantity}
              onChange={handleChangeQuantity}
            />
            <LoadingButton
              disabled={
                item?.quantity === quantity || (!item && quantity === 0)
              }
              loading={status.includes('pending')}
              variant='outlined'
              size='large'
              sx={{ marginLeft: '16px', color: 'secondary.dark' }}
              onClick={handleUpdateQuantity}
            >
              {!item ? 'Add To Cart' : 'Update Quantity'}
            </LoadingButton>
          </Box>
        </Grid>
      </Grid>
    </>
  );
};

export default ProductDetails;
