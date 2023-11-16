import { createAsyncThunk, createSlice } from '@reduxjs/toolkit';
import { RootState } from '../../app/store/configureStore';
import { Basket } from '../../app/models/Basket';
import agent from '../../api/agent';

interface BasketState {
  basket: Basket | null;
  status: string;
}

export const addBasketItemsAsync = createAsyncThunk<
  Basket,
  { productId: number; quantity: number }
>('basket/addBasketItemsAsync', async ({ productId, quantity }) => {
  return await agent.Basket.addItem(productId, quantity);
});

export const removeBasketItemsAsync = createAsyncThunk<
  Basket,
  { productId: number; quantity: number; name: string }
>('basket/removeBasketItemsAsync', async ({ productId, quantity }) => {
  return await agent.Basket.removeItem(productId, quantity);
});

const initialState: BasketState = {
  basket: null,
  status: 'idle',
};

export const basketSlice = createSlice({
  name: 'basket',
  initialState,
  reducers: {
    setBasket: (state, action) => {
      state.basket = action.payload;
    },
  },
  extraReducers: (builder) => {
    builder.addCase(addBasketItemsAsync.pending, (state, action) => {
      state.status = 'pendingAddItem' + action.meta.arg.productId;
    });
    builder.addCase(addBasketItemsAsync.fulfilled, (state, action) => {
      state.basket = action.payload;
      state.status = 'idle';
    });
    builder.addCase(addBasketItemsAsync.rejected, (state) => {
      state.status = 'idle';
    });

    builder.addCase(removeBasketItemsAsync.pending, (state, action) => {
      state.status =
        'pendingRemoveItem' + action.meta.arg.productId + action.meta.arg.name;
    });
    builder.addCase(removeBasketItemsAsync.fulfilled, (state, action) => {
      state.basket = action.payload;
      state.status = 'idle';
    });
    builder.addCase(removeBasketItemsAsync.rejected, (state) => {
      state.status = 'idle';
    });
  },
});

export const { setBasket } = basketSlice.actions;

export const selectCount = (state: RootState) => state.basket;
