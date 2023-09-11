import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { FullProject, Project } from 'src/app/models/Project';
import { AuthService } from 'src/app/Services/auth.service';
import { ModalService } from 'src/app/Services/modal.service';
import { ProjectService } from 'src/app/Services/project.service';
import { ResponseService } from 'src/app/Services/response.service';

@Component({
  selector: 'app-projects-list',
  templateUrl: './projects-list.component.html',
  styleUrls: ['./projects-list.component.scss']
})
export class ProjectsListComponent {
  // define a variable to hold the projects
  projects: FullProject[] = [];
  editedProject: Project = { id: 0, title: '', description: '', createdAt: new Date(), updatedAt: new Date() };
  newProject: any = { title: '', description: '' };
  sub1: Subscription = new Subscription;
  addModal = true;
  modalTitle = "Add Project";
  deleteProjectId = 0;

  constructor(private projectService: ProjectService, private router: Router, private modalService: ModalService
    , private responseService: ResponseService
  ) { }

  //get user id from local storage


  ngOnInit() {

    this.sub1 = this.projectService.getProjects().subscribe(
      (res) => {
        res.forEach((p: any) => {
          delete p.participators;
          delete p.assignments;
        })

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
        let errors = this.responseService.getErrorMessage(err);
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
          let errors = this.responseService.getErrorMessage(err);
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
