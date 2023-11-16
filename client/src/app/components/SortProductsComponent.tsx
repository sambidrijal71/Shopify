import {
  FormControl,
  FormControlLabel,
  Radio,
  RadioGroup,
} from '@mui/material';

interface Props {
  options: {
    label: string;
    value: string;
  }[];
  onChange: (event: any) => void;
  selectedValue: string;
}
const SortProductsComponent = ({ options, onChange, selectedValue }: Props) => {
  return (
    <FormControl>
      <RadioGroup onChange={onChange} value={selectedValue}>
        {options.map(({ label, value }) => (
          <FormControlLabel
            key={label}
            value={value}
            control={<Radio />}
            label={label}
          />
        ))}
      </RadioGroup>
    </FormControl>
  );
};

export default SortProductsComponent;
