import { Routes } from "@angular/router";
import { AuthFormComponent } from "../components/auth-form/auth-form.component";
import { ProjectDetailsComponent } from "../components/project-details/project-details.component";
import { ProjectsComponent } from "../components/project/projects.component";
import { AuthGuard } from "../helpers/AuthGuard";
import { LoginGuard } from "../helpers/LoginGuard";

export const appRoutes: Routes = [
    //specify the path and the component with its properties    
    { path: 'home', component: ProjectsComponent, canActivate: [AuthGuard] },
    { path: 'login', component: AuthFormComponent, data: { isLoginMode: true, title: 'Login'}, canActivate: [LoginGuard] },
    { path: 'register', component: AuthFormComponent, data: { isLoginMode: false, title: 'Register' }, canActivate: [LoginGuard] },
    //project details with parameter
    { path: 'project/:id', component: ProjectDetailsComponent, canActivate: [AuthGuard] },
];
