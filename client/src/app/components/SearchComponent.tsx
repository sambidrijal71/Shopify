import { TextField } from '@mui/material';
import { useAppDispatch } from '../store/configureStore';
import { setProductParams } from '../../features/catalog/catalogSlice';
import { useState } from 'react';

const SearchComponent = () => {
  const dispatch = useAppDispatch();
  const [searchTerm, setSearchTerm] = useState('');
  console.log(searchTerm);
  return (
    <TextField
      id='filled-search'
      label='Search Products'
      type='search'
      variant='outlined'
      fullWidth
      value={searchTerm}
      onChange={(e: React.ChangeEvent<HTMLInputElement>) => {
        e.preventDefault();
        setSearchTerm(e.target.value);
      }}
      onKeyDown={(e) => {
        if (e.key == 'Enter') {
          dispatch(setProductParams({ searchTerm: searchTerm }));
        }
      }}
    />
  );
};

export default SearchComponent;
