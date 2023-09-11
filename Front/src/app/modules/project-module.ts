import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AsignmtsListComponent } from '../components/projectComponents/asignmts-list/asignmts-list.component';
import { AssignmentFormComponent } from '../components/projectComponents/assignment-form/assignment-form.component';
import { ProjectDetailsComponent } from '../components/projectComponents/project-details/project-details.component';
import { ProjectItemComponent } from '../components/projectComponents/project-item/project-item.component';
import { ProjectsComponent } from '../components/projectComponents/project/projects.component';
import { UserFormComponent } from '../components/projectComponents/user-form/user-form.component';
import { UsersListComponent } from '../components/projectComponents/users-list/users-list.component';
import { AuthGuard } from '../helpers/AuthGuard';
import { MytasksComponent } from '../components/projectComponents/mytasks/mytasks.component';
import { SharedModule } from './shared-module';
import { SelectInputComponent } from '../components/sharedComponents/select-input/select-input.component';
import { KanbanComponent } from '../components/projectComponents/kanban/kanban.component';
import { TaskCardComponent } from '../components/projectComponents/task-card/task-card.component';
import { InvitationsComponent } from '../components/projectComponents/invitations/invitations.component';



const routes: Routes = [
    { path: 'myprojects', component: ProjectsComponent, canActivate: [AuthGuard] },
    { path: 'edit/:id', component: ProjectDetailsComponent, canActivate: [AuthGuard] },
    { path: 'mytasks', component: MytasksComponent, canActivate: [AuthGuard] }   , 
    {path: 'invitations', component: InvitationsComponent, canActivate: [AuthGuard]}
]


@NgModule({
    declarations: [
        ProjectsComponent,
        ProjectItemComponent,
        ProjectDetailsComponent,        
        AsignmtsListComponent,       
        AssignmentFormComponent,
        UserFormComponent,
        UsersListComponent,      
        SelectInputComponent,
        MytasksComponent,
        KanbanComponent,
        TaskCardComponent        

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