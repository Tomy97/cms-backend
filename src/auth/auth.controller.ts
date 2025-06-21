import { Body, Controller, Post } from '@nestjs/common';
import { AuthService } from './auth.service';
import { ApiBody, ApiTags } from '@nestjs/swagger';
import { User } from 'src/models';
// Dto
import { LoginAuthDto } from './dto/login-auth.dto';
import { RegisterAuthDto } from './dto/register-auth.dto'
import { EmailValidatorDto } from './dto/email-validator.dto'
@ApiTags('Auth')
@Controller('auth')
export class AuthController {
  constructor(
    private authService: AuthService
  ) {}
  @ApiBody({ type: LoginAuthDto })
  @Post('login')
  async login(@Body() loginDto: LoginAuthDto): Promise<{access_token: string}> {
    return this.authService.login(loginDto);
  }

  @ApiBody({ type: RegisterAuthDto })
  @Post('register')
  async register(@Body() registerAuthDto: RegisterAuthDto): Promise<User> {
    return this.authService.register(registerAuthDto);
  }

  @ApiBody({ type: EmailValidatorDto })
  @Post('email-validator')
  async emailValidator(@Body() { email }: EmailValidatorDto): Promise<boolean> {
    return this.authService.validateEmailExist(email)
  }
}
