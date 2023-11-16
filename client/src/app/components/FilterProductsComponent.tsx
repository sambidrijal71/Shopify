import { FormGroup, FormControlLabel, Checkbox, Button } from '@mui/material';
import { useState } from 'react';

interface Props {
  filters: string[];
  checked: string[];
  onChange: (filters: string[]) => void;
}
const FilterProductsComponent = ({ filters, checked, onChange }: Props) => {
  const [showMore, setShowMore] = useState(false);
  const [checkedItems, setCheckedItems] = useState(checked || []);

  const handleChecked = (value: string) => {
    const currentIndex = checkedItems.findIndex((i) => i === value);
    let newChecked: string[] = [];
    if (currentIndex === -1) newChecked = [...checkedItems, value];
    else newChecked = checkedItems.filter((item) => item !== value);
    setCheckedItems(newChecked);
    onChange(newChecked);
  };

  return (
    <FormGroup>
      {filters.slice(0, showMore ? filters.length : 8).map((filter) => (
        <FormControlLabel
          key={filter}
          control={<Checkbox checked={checkedItems.indexOf(filter) !== -1} />}
          onClick={() => handleChecked(filter)}
          label={filter.charAt(0).toUpperCase() + filter.slice(1)}
        />
      ))}
      {!showMore ? (
        <Button
          sx={{ color: 'secondary.dark' }}
          variant='outlined'
          size='small'
          onClick={() => {
            setShowMore(true);
          }}
        >
          View more
        </Button>
      ) : (
        <Button
          sx={{ color: 'secondary.dark' }}
          variant='outlined'
          size='small'
          onClick={() => {
            setShowMore(false);
          }}
        >
          View less
        </Button>
      )}
    </FormGroup>
  );
};

export default FilterProductsComponent;
