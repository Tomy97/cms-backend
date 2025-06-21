import { ApiProperty } from '@nestjs/swagger';
import { IsEmail } from 'class-validator';

export class EmailValidatorDto {
  @IsEmail()
  @ApiProperty({ example: 'test@example.com' })
  email: string;
}