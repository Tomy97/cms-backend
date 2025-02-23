import { BadRequestException, Injectable } from '@nestjs/common';
import { JwtService } from '@nestjs/jwt';
import { User } from 'src/models';
import { UserRequest } from 'src/types/user.request';
import { UsersService } from 'src/users/users.service';

@Injectable()
export class AuthService {
  constructor(
    private usersService: UsersService,
    private jwtService: JwtService,
  ) {}

  async validateUser(email: string, pass: string): Promise<User> {
    const user = await this.usersService.findOne(email);
    if (user && user.password === pass) {
      const { ...result } = user;
      return result;
    }
  }

  async login(user: UserRequest) {
    try {
      const credentials = await this.validateUser(user.email, user.password);
      const payload = { email: credentials.email };
      return {
        access_token: this.jwtService.sign(payload),
      };
    } catch (error: any) {
      console.error(error)
      throw new BadRequestException('Usuario no encontrado');
    }
  }

  async register(user: UserRequest) {
    const exists = await this.usersService.findUserExist(user.email);
    if (exists) {
      throw new BadRequestException('Usuario ya existe');
    }
    return this.usersService.create(user);
  }
}
