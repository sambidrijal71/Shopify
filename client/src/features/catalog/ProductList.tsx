import { Grid } from '@mui/material';
import { Product } from '../../app/models/Product';
import ProductCard from './ProductCard';

interface Props {
  products: Product[];
}
const ProductList = ({ products }: Props) => {
  return (
    <Grid container spacing={3}>
      {products.map((product) => (
        <Grid item xs={4} key={product.id}>
          <ProductCard product={product} />
        </Grid>
      ))}
    </Grid>
  );
};

export default ProductList;
