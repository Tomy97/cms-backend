import { ApiProperty } from "@nestjs/swagger";
import { IsEmail, IsString, MinLength } from "class-validator";

export class RegisterAuthDto {
  @IsString()
  @IsEmail()
  @ApiProperty({ example: 'test@example.com' })
  email: string;
  
  @IsString()
  @MinLength(8)
  @ApiProperty({ example: '123456789' })
  password: string;
}