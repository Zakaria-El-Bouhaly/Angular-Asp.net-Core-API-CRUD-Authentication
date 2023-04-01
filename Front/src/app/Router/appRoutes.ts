import { Routes } from "@angular/router";
import { AuthFormComponent } from "../components/auth-form/auth-form.component";
import { AuthGuard } from "../helpers/AuthGuard";
import { LoginGuard } from "../helpers/LoginGuard";

export const appRoutes: Routes = [
    { path: '', redirectTo: 'myprojects', pathMatch: 'full' },
    { path: 'projects', loadChildren: () => import('../modules/project-module').then(m => m.ProjectModule), canActivate: [AuthGuard] },
    { path: 'login', component: AuthFormComponent, data: { isLoginMode: true, title: 'Login' }, canActivate: [LoginGuard] },
    { path: 'register', component: AuthFormComponent, data: { isLoginMode: false, title: 'Register' }, canActivate: [LoginGuard] }
];
