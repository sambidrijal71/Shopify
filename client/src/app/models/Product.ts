export interface Product {
  id: number;
  name: string;
  description: string;
  price: number;
  discountPercentage: number;
  rating: number;
  quantityInStock: number;
  brand: string;
  category: string;
  thumbnail: string;
  images: string[];
  imageJson: string;
}

export interface ProductParams {
  orderBy: string;
  searchTerm?: string;
  brands: string[];
  categories: string[];
  pageNumber: number;
  pageSize: number;
}
