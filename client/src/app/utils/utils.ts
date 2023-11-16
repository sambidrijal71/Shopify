export const getCookie = (key: string) => {
  const cookie = RegExp('(^|;)\\s*' + key + '\\s*=\\s*([^;]+)').exec(
    document.cookie
  );
  return cookie;
};

export const currencyConverter = (price: number) => {
  return (price / 100).toFixed(2);
};
