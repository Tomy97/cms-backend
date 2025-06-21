import jwt, { SignOptions } from 'jsonwebtoken';
import { User } from '../models/User.model';
export const jwtGenerate = (user: User) => {
  const secretKey: string = process.env.JWT_SECRET

  const options: SignOptions = {
    expiresIn: process.env.JWT_EXPIRES,
  }

  return jwt.sign(user, secretKey, options);
}