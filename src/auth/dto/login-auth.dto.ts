import { ApiProperty } from '@nestjs/swagger';
import { IsEmail, IsString, MinLength } from 'class-validator';
export class LoginAuthDto {
  @IsString()
  @IsEmail()
  @ApiProperty({ example: 'test@example.com' })
  email: string;
  
  @IsString()
  @MinLength(8)
  @ApiProperty({ example: '12345678' })
  password: string;
} 