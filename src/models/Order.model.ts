import { PaymentMethod } from './PaymentMethod.model';
import { Product } from './Product.model';
import { State } from './State.model';

export type Order = {
  id: number;
  userId: number;
  clientId: number;
  stateId: number;
  productId: number;
  paymentMethodId: number;
  deliveryDate: Date;
  description: string;
  state: State;
  product: Product;
  paymentMethod: PaymentMethod;
  createdAt: Date;
  updatedAt: Date;
};
