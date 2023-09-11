import { provideImageKitLoader } from '@angular/common';
import { Component, ViewChild } from '@angular/core';
import { Router } from '@angular/router';
import { of, Subscription } from 'rxjs';
import { AuthService } from 'src/app/Services/auth.service';
import { ModalService } from 'src/app/Services/modal.service';
import { Project } from '../../../models/Project';
import { ProjectService } from '../../../Services/project.service';
import { ResponseService } from 'src/app/Services/response.service';



@Component({
  selector: 'app-projects',
  templateUrl: './projects.component.html',
  styleUrls: ['./projects.component.scss']
})




export class ProjectsComponent {
  // define a variable to hold the projects
  projects: Project[] = [];
  editedProject: Project = { id: 0, title: '', description: '', createdAt: new Date(), updatedAt: new Date() };
  newProject: any = { title: '', description: '' };
  sub1: Subscription = new Subscription;
  addModal = true;
  modalTitle = "Add Project";
  deleteProjectId = 0;

  constructor(private projectService: ProjectService, private authService: AuthService, private router: Router, private modalService: ModalService,
    private respoService: ResponseService
    ) { }

  //get user id from local storage


  ngOnInit() {

    this.sub1 = this.projectService.getUserProjects(this.authService.getUserId()).subscribe(
      (res) => {
        this.projects = res;
      }
    );
  }

  addnewProject(newProject: any) {
    this.projectService.addProject(newProject).subscribe({
      next: (res) => {
        let createdProject = res;
        this.projects.push(createdProject);
        this.modalService.setModalSuccess("Project added successfully!");
      },
      error: (err) => {
        let errors = this.respoService.getErrorMessage(err);
        this.modalService.setModalError(errors);
      }
    });
  }

  editProject(project: Project) {
    
    this.router.navigate(['/edit/' + project.id]);
  }

  deleteProject() {
    
    this.projectService.deleteProject(this.deleteProjectId).subscribe(
      {
        next: (res) => {
          this.projects = this.projects.filter(p => p.id !== this.deleteProjectId);
          this.modalService.setModalSuccess("Project deleted successfully!");
        },
        error: (err) => {
          let errors = this.respoService.getErrorMessage(err);
          this.modalService.setModalError(errors);
        }
      }
    );

  }

  openDeleteModal(p: Project) {
    this.addModal = false;
    this.modalTitle = "Delete Project";
    this.deleteProjectId = p.id;
    this.modalService.openModal();

  }

  openAddModal() {
    this.addModal = true;
    this.modalTitle = "Add Project";
    this.modalService.openModal();
  }

  closeModal() {
    this.modalService.closeModal();
  }

  ngOnDestroy() {
    this.sub1.unsubscribe();
  }
}
