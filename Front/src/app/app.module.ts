import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { HeaderComponent } from './components/header/header.component';
import { ProjectsComponent } from './components/project/projects.component';
import { ProjectItemComponent } from './components/project/project-item/project-item.component';
import { appRoutes } from './Router/appRoutes';
import { AuthFormComponent } from './components/auth-form/auth-form.component';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { ProjectDetailsComponent } from './components/project-details/project-details.component';
import { MytableComponent } from './components/mytable/mytable.component';
import { HttpInterceptorService } from './Services/http-interceptor.service';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ModalComponent } from './components/modal/modal.component';
import { ProjectFormComponent } from './components/project-form/project-form.component';
import { ConfirmationDialogComponent } from './components/confirmation-dialog/confirmation-dialog.component';
import { ToggleBtnComponent } from './components/toggle-btn/toggle-btn.component';
import { AssignmentFormComponent } from './components/assignment-form/assignment-form.component';
import { UserFormComponent } from './components/user-form/user-form.component';
import { UsersListComponent } from './components/users-list/users-list.component';
import { AsignmtsListComponent } from './components/asignmts-list/asignmts-list.component';
import { SharedListComponent } from './components/shared-list/shared-list.component';






@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    ProjectsComponent,
    ProjectItemComponent,
    AuthFormComponent,
    ProjectDetailsComponent,
    MytableComponent,
    ModalComponent,
    ProjectFormComponent,
    ConfirmationDialogComponent,
    ToggleBtnComponent,
    AssignmentFormComponent,
    UserFormComponent,
    UsersListComponent,
    AsignmtsListComponent,
    SharedListComponent


  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot(appRoutes),
    HttpClientModule,
    ReactiveFormsModule,
    BrowserAnimationsModule
  ],
  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: HttpInterceptorService,
      multi: true

    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
