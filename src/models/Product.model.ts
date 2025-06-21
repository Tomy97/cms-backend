import { Category } from "./Category.model";

export type Product = {
  id: number;
  userId: number
  categoryId: number
  title: string
  price: number
  stock: number
  image: string
  description: string
  createdAt: Date
  updatedAt: Date
  category: Category
}