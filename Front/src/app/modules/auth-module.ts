import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { AuthFormComponent } from '../components/auth-form/auth-form.component';
import { GoogleSignInBtnComponent } from '../components/google-sign-in-btn/google-sign-in-btn.component';
import { SharedModule } from './shared-module';

@NgModule({
    declarations: [
        AuthFormComponent,
        GoogleSignInBtnComponent
    ],
    imports: [
        SharedModule,
        RouterModule      
    ],
    exports: [
        
    ],
    providers: [
    ]
})

export class AuthModule { }