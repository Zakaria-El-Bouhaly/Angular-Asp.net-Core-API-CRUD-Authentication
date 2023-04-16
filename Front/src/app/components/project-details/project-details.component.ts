import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Subscription } from 'rxjs';
import { FullProject } from 'src/app/models/Project';
import { AssignmentService } from 'src/app/Services/assignment.service';
import { ModalService } from 'src/app/Services/modal.service';
import { ProjectService } from "../../Services/project.service";




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
        console.log(resultProject);
        this.project = resultProject;

        this.participators = resultProject.participators ?? [];      
        this.participators.forEach((participator) => {
          participator.user = participator.user.name;
        });

        this.allAssignments = resultProject.assignments ?? [];
        this.allAssignments.forEach((assignment) => {
          assignment.user = assignment.user.name;
        });
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

  deleteParticipant(participantIndex: any) {
    // delete element by index
    this.participators.splice(this.participators.indexOf(participantIndex), 1);
    console.log(this.participators);
  }

  deleteAssignment(assignmentIndex: any) {
    // delete element by index
    this.allAssignments = this.allAssignments.filter((assignment) => assignment.id != assignmentIndex);
    console.log(this.allAssignments);
  }
  ngOnDestroy() {
    this.subProject.unsubscribe();
  }

}
