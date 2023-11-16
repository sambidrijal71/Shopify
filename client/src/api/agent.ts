import axios, { AxiosError, AxiosResponse } from 'axios';
import { toast } from 'react-toastify';
import router from '../app/routes/router';

axios.defaults.baseURL = 'http://localhost:5000/api/';
axios.defaults.withCredentials = true;
const sleep = () => new Promise((resolve) => setTimeout(resolve, 500));
axios.interceptors.response.use(
  async (response) => {
    await sleep();
    return response;
  },
  (error: AxiosError) => {
    const { data, status } = error.response as AxiosResponse;
    switch (status) {
      case 400:
        if (data.errors) {
          const modelStateErrors: string[] = [];
          for (const key in data.errors) {
            if (data.errors[key]) {
              modelStateErrors.push(data.errors[key]);
            }
          }
          throw modelStateErrors.flat();
        }
        toast.error(data.title);
        break;
      case 401:
        toast.error(data.title);
        break;
      case 402:
        toast.error(data.title);
        break;
      case 404:
        router
          .navigate('/not-found', { state: { error: data } })
          .then(() => toast.error(data.title));

        break;
      case 500:
        router
          .navigate('/server-error', { state: { error: data } })
          .then(() => toast.error(data.title));
        break;
      default:
        break;
    }

    return Promise.reject(error.response);
  }
);

const responseBody = (response: AxiosResponse) => response.data;

const requests = {
  get: (url: string, params?: URLSearchParams) =>
    axios.get(url, { params }).then(responseBody),
  post: (url: string, body: object) => axios.post(url, body).then(responseBody),
  put: (url: string, body: string) => axios.put(url, body).then(responseBody),
  delete: (url: string) => axios.delete(url).then(responseBody),
};

const Catalog = {
  lists: (params: URLSearchParams) => requests.get('product', params),
  detail: (id: number) => requests.get(`product/${id}`),
  filters: () => requests.get('product/filters'),
};

const Basket = {
  get: () => requests.get('basket'),
  addItem: (productId: number, quantity = 1) =>
    requests.post(`basket?productId=${productId}&quantity=${quantity}`, {}),
  removeItem: (productId: number, quantity = 1) =>
    requests.delete(`basket?productId=${productId}&quantity=${quantity}`),
};

const TestErrors = {
  get400Error: () => requests.get('buggy/bad-request'),
  get401Error: () => requests.get('buggy/unauthorised'),
  get404Error: () => requests.get('buggy/not-found'),
  get500Error: () => requests.get('buggy/server-error'),
  getValidationError: () => requests.get('buggy/validation-error'),
};
const agent = {
  Catalog,
  Basket,
  TestErrors,
};
export default agent;
