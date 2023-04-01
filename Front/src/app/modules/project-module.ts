import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AsignmtsListComponent } from '../components/asignmts-list/asignmts-list.component';
import { AssignmentFormComponent } from '../components/assignment-form/assignment-form.component';
import { ConfirmationDialogComponent } from '../components/confirmation-dialog/confirmation-dialog.component';
import { MytableComponent } from '../components/mytable/mytable.component';
import { ProjectDetailsComponent } from '../components/project-details/project-details.component';
import { ProjectFormComponent } from '../components/project-form/project-form.component';
import { ProjectItemComponent } from '../components/project/project-item/project-item.component';
import { ProjectsComponent } from '../components/project/projects.component';
import { UserFormComponent } from '../components/user-form/user-form.component';
import { UsersListComponent } from '../components/users-list/users-list.component';
import { AuthGuard } from '../helpers/AuthGuard';
import { AssignmentService } from '../Services/assignment.service';
import { ProjectService } from '../Services/project.service';
import { SharedModule } from './shared-module';


const routes: Routes = [
    { path: 'myprojects', component: ProjectsComponent, canActivate: [AuthGuard] },
    { path: 'edit/:id', component: ProjectDetailsComponent, canActivate: [AuthGuard] },

]


@NgModule({
    declarations: [
        ProjectsComponent,
        ProjectItemComponent,
        ProjectDetailsComponent,
        ProjectFormComponent,
        ConfirmationDialogComponent,
        AsignmtsListComponent,
        MytableComponent,
        AssignmentFormComponent,
        UserFormComponent,
        UsersListComponent
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

export class ProjectModule { }