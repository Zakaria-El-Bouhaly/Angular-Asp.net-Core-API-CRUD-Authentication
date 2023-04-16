import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AsignmtsListComponent } from '../components/asignmts-list/asignmts-list.component';
import { AssignmentFormComponent } from '../components/assignment-form/assignment-form.component';
import { ProjectDetailsComponent } from '../components/project-details/project-details.component';
import { ProjectItemComponent } from '../components/project/project-item/project-item.component';
import { ProjectsComponent } from '../components/project/projects.component';
import { UserFormComponent } from '../components/user-form/user-form.component';
import { UsersListComponent } from '../components/users-list/users-list.component';
import { AuthGuard } from '../helpers/AuthGuard';
import { MytasksComponent } from '../mytasks/mytasks.component';
import { SharedModule } from './shared-module';
import { SelectInputComponent } from '../components/select-input/select-input.component';
import { KanbanComponent } from '../components/kanban/kanban.component';
import { TaskCardComponent } from '../components/task-card/task-card.component';



const routes: Routes = [
    { path: 'myprojects', component: ProjectsComponent, canActivate: [AuthGuard] },
    { path: 'edit/:id', component: ProjectDetailsComponent, canActivate: [AuthGuard] },
    { path: 'mytasks', component: MytasksComponent, canActivate: [AuthGuard] }    
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