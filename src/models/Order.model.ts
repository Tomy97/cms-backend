import { PaymentMethod } from './PaymentMethod.model';
import { Product } from './Product.model';
import { State } from './State.model';

export type Order = {
  idOrder: number;
  userId: number;
  clientId: number;
  stateId: number;
  productId: number;
  product: Product;
  state: State;
  paymentMethod: PaymentMethod;
  paymentMethodId: number;
  deliveryDate: Date;
  description: string;
  createdAt: Date;
  updatedAt: Date;
};
