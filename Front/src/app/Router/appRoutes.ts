import { Routes } from "@angular/router";
import { AuthFormComponent } from "../components/Auth/auth-form/auth-form.component";
import { AdminGuard } from "../helpers/AdminGuard";
import { AuthGuard } from "../helpers/AuthGuard";
import { LoginGuard } from "../helpers/LoginGuard";

export const appRoutes: Routes = [
    { path: '', redirectTo: 'myprojects', pathMatch: 'full' },
    { path: 'projects', loadChildren: () => import('../modules/project-module').then(m => m.ProjectModule), canActivate: [AuthGuard] },    
    { path: 'admin', loadChildren: () => import('../modules/admin-module').then(m => m.AdminModule) , canActivate: [AdminGuard]},
    { path: 'profile', loadChildren: () => import('../modules/profile-module').then(m => m.ProfileModule), canActivate: [AuthGuard] },
];
