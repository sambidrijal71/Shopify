import { useEffect } from 'react';
import ProductList from './ProductList';
import LoadingComponent from '../../app/components/LoadingComponent';
import { useAppDispatch, useAppSelector } from '../../app/store/configureStore';
import {
  fetchFiltersAsync,
  fetchProductsAsync,
  productSelector,
  setProductParams,
} from './catalogSlice';
import { Box, Grid, Pagination, Paper, Typography } from '@mui/material';
import SearchComponent from '../../app/components/SearchComponent';
import SortProductsComponent from '../../app/components/SortProductsComponent';
import FilterProductsComponent from '../../app/components/FilterProductsComponent';

const sortOptions = [
  { label: 'Alphabetical', value: 'name' },
  { label: 'Price - High First', value: 'priceDesc' },
  { label: 'Price - Low First', value: 'price' },
  { label: 'Rating - High First', value: 'rating' },
  { label: 'Discount - High First', value: 'discount' },
];
const Catalog = () => {
  const {
    productsLoaded,
    status,
    filtersLoaded,
    brands,
    categories,
    productParams,
  } = useAppSelector((state) => state.catalog);
  const products = useAppSelector(productSelector.selectAll);
  const dispatch = useAppDispatch();

  useEffect(() => {
    if (!productsLoaded) dispatch(fetchProductsAsync());
  }, [productsLoaded, dispatch]);

  useEffect(() => {
    if (!filtersLoaded) dispatch(fetchFiltersAsync());
  }, [filtersLoaded, dispatch]);

  if (status.includes('pendingFetch') || !products)
    return <LoadingComponent message='Loading Products...' />;

  return (
    <Grid container spacing={3}>
      <Grid item xs={3}>
        <Paper variant='outlined' sx={{ mb: 2 }}>
          <SearchComponent />
        </Paper>
        <Paper variant='outlined' sx={{ mb: 2, p: 2 }}>
          <SortProductsComponent
            options={sortOptions}
            onChange={(event) =>
              dispatch(setProductParams({ orderBy: event.target.value }))
            }
            selectedValue={productParams.orderBy}
          />
        </Paper>
        <Paper variant='outlined' sx={{ mb: 2, p: 2 }}>
          <FilterProductsComponent
            filters={brands as []}
            checked={productParams.brands}
            onChange={(filters: string[]) =>
              dispatch(setProductParams({ brands: filters }))
            }
          />
        </Paper>

        <Paper variant='outlined' sx={{ mb: 2, p: 2 }}>
          <FilterProductsComponent
            filters={categories}
            checked={productParams.categories}
            onChange={(filters) =>
              dispatch(setProductParams({ categories: filters }))
            }
          />
        </Paper>
      </Grid>
      <Grid item xs={9}>
        <ProductList products={products} />
        <Box
          marginTop={4}
          paddingX={2}
          display={'flex'}
          justifyContent={'space-between'}
          alignItems={'center'}
        >
          <Typography variant={'h6'}>Showing 1-9 of 100 items</Typography>
          <Pagination count={10} color='secondary' size='large' />
        </Box>
      </Grid>
    </Grid>
  );
};

export default Catalog;
