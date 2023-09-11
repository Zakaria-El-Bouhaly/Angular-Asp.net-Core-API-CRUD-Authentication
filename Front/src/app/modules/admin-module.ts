import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardComponent } from '../components/Admin/dashboard/dashboard.component';
import { FullUserFormComponent } from '../components/Admin/full-user-form/full-user-form.component';
import { ProjectsListComponent } from '../components/Admin/projects-list/projects-list.component';
import { SidebarComponent } from '../components/Admin/sidebar/sidebar.component';
import { UsersComponent } from '../components/Admin/users/users.component';

import { ProjectDetailsComponent } from '../components/projectComponents/project-details/project-details.component';
import { AdminGuard } from '../helpers/AdminGuard';
import { SharedModule } from './shared-module';

const routes: Routes = [
    {
        path: '', component: DashboardComponent, canActivate: [AdminGuard], children: [
            { path: 'edit/:id', component: ProjectDetailsComponent, canActivate: [AdminGuard] },
            { path: 'users', component: UsersComponent, canActivate: [AdminGuard] },
            { path: 'projects', component: ProjectsListComponent, canActivate: [AdminGuard] },
        ]
    }
    ,

    { path: '**', redirectTo: '' }
]


@NgModule({
    declarations: [
        DashboardComponent,
        SidebarComponent,
        UsersComponent,
        ProjectsListComponent,
        FullUserFormComponent
    ],
    imports: [
        SharedModule,
        RouterModule.forChild(routes)
    ],
    exports: [

    ],
    providers: [
    ]
})

export class AdminModule { }