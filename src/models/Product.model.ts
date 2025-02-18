import { Category } from "./Category.model";

export type Product = {
  productId: number;
  userId: number
  categoryId: number
  title: string
  price: number
  stock: number
  category: Category // cambiar por el tipo
  image: string
  description: string
  createdAt: Date
  updatedAt: Date
}