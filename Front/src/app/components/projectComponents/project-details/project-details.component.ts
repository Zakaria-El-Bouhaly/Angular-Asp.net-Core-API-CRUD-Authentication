import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Subscription } from 'rxjs';
import { FullProject } from 'src/app/models/Project';
import { AssignmentService } from 'src/app/Services/assignment.service';
import { ModalService } from 'src/app/Services/modal.service';
import { ProjectService } from "../../../Services/project.service";




@Component({
  selector: 'app-project-details',
  templateUrl: './project-details.component.html',
  styleUrls: ['./project-details.component.scss']
})
export class ProjectDetailsComponent {

  project: FullProject = { id: 0, title: "", description: "", createdAt: new Date(), updatedAt: new Date(), assignments: [], ownerId: 0, participators: [] };
  subProject!: Subscription;
  projectId: any;
  participators: any[] = [];
  allAssignments: any[] = [];
  errorMessage: string = "";
  successMessage: string = "";
  activeTab: string = "ProjectInfo";
  states = ["Not Started", "In Progress", "Completed"];


  constructor(private route: ActivatedRoute, private projectService: ProjectService, private assignmentService: AssignmentService, private modalService: ModalService) { }

  ngOnInit() {
    //get project id from url route   
    this.projectId = this.route.snapshot.paramMap.get('id')
    this.subProject = this.projectService.getProjectById(this.projectId).subscribe({
      next: (resultProject) => {
        
        this.project = resultProject;

        this.participators = resultProject.participators ?? [];      
        

        this.allAssignments = resultProject.assignments ?? [];
        
      },
      error: (err) => {
        this.errorMessage = err.error.message;
      }
    });
  }

  onTabClick(tab: string) {
    this.activeTab = tab;
  }


  updateProject(updatedPoject: any) {
    this.projectService.updateProject(updatedPoject).subscribe({
      next: (res) => {
        this.setSuccessMessage("Project updated successfully");
        this.project.title = updatedPoject.title;
        this.project.description = updatedPoject.description;
      },
      error: (err) => {
        this.setErrorMessage("Error updating project");
      }
    });
  }

  setSuccessMessage(msg: string) {
    this.successMessage = msg;
    this.errorMessage = "";
  }

  setErrorMessage(msg: string) {
    this.successMessage = "";
    this.errorMessage = msg;
  }

  onActionAsg(asgts:any){
    this.allAssignments=asgts;
  }

  onActionParticp(participators:any){
    
    this.participators=participators;
  }

  ngOnDestroy() {
    this.subProject.unsubscribe();
  }

}
