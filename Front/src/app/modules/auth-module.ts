import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { AuthFormComponent } from '../components/Auth/auth-form/auth-form.component';
import { EmailVerifComponent } from '../components/Auth/email-verif/email-verif.component';
import { ForgotPasswordComponent } from '../components/Auth/forgot-password/forgot-password.component';
import { ResetPasswordComponent } from '../components/Auth/reset-password/reset-password.component';
import { GoogleSignInBtnComponent } from '../components/Auth/google-sign-in-btn/google-sign-in-btn.component';
import { LoginGuard } from '../helpers/LoginGuard';
import { SharedModule } from './shared-module';

const authRoutes = [
    { path: 'login', component: AuthFormComponent, data: { isLoginMode: true, title: 'Login' }, canActivate: [LoginGuard] },
    { path: 'register', component: AuthFormComponent, data: { isLoginMode: false, title: 'Register' }, canActivate: [LoginGuard] },
    { path: 'verify-email', component: EmailVerifComponent },
    { path: 'forgot-password', component: ForgotPasswordComponent },
    { path: 'reset-password', component: ResetPasswordComponent }    
];
@NgModule({
    declarations: [
        AuthFormComponent,
        GoogleSignInBtnComponent,
        EmailVerifComponent,
        ResetPasswordComponent,
        ForgotPasswordComponent        
    ],
    imports: [
        SharedModule,
        RouterModule.forChild(authRoutes)
    ],
    exports: [

    ],
    providers: [
    ]
})

export class AuthModule { }