import { User } from '../../../../models';

export type UserRequest = Omit<User, 'id' | 'createdAt' | 'updatedAt'>