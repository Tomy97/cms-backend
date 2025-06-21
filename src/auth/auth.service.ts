import { BadRequestException, Injectable } from '@nestjs/common';
import { JwtService } from '@nestjs/jwt';
import { User } from 'src/models';
import { UserRequest } from 'src/modules/users/dtos/request/user.request';
import { UsersService } from 'src/modules/users/users.service';
import * as bcrypt from 'bcrypt';

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

  async login(user: UserRequest): Promise<{
    access_token: string
  }> {
    try {
      const credentials: User = await this.validateUser(user.email, user.password);
      const payload: User = credentials;
      return {
        access_token: this.jwtService.sign(payload),
      };
    } catch (error) {
      throw new BadRequestException(error);
    }
  }

  async register(user: UserRequest): Promise<User> {
    const exists = await this.usersService.findUserExist(user.email);
    if (exists) {
      throw new BadRequestException('Usuario ya existe');
    }
    const saltOrRounds: number = 4;
    const hashedPassword: string = await bcrypt.hash(
      user.password,
      saltOrRounds,
    );
    const userToCreate = {
      ...user,
      password: hashedPassword,
    }
    return this.usersService.create(userToCreate);
  }

  async validateEmailExist(email: string): Promise<boolean> {
    try {
      return await this.usersService.hasEmailExist(email)
    } catch (e) {
      throw new BadRequestException(e);
    }
  }
}
