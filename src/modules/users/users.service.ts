import { Injectable } from '@nestjs/common';
import { User } from 'src/models';
import { PrismaService } from 'src/prisma/prisma.service';
import { UserRequest } from 'src/modules/users/dtos/request/user.request';

@Injectable()
export class UsersService {
  constructor(private readonly prisma: PrismaService) {}

  async findOne(email: string): Promise<User | null> {
    return this.prisma.user.findUnique({
      where: { email },
    });
  }

  async findUserExist(email: string): Promise<boolean> {
    const user = await this.findOne(email);
    return !!user;
  }

  async create(data: UserRequest): Promise<User> {
    return this.prisma.user.create({
      data
    });
  }

  async hasEmailExist(email: string): Promise<boolean> {
    const countEmails: number = await this.prisma.user.count({
      where: { email }
    })

    return countEmails > 0;
  }
}
