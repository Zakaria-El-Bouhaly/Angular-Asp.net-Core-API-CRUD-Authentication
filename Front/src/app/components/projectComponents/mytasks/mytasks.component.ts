import { Component } from '@angular/core';
import { Assignment } from '../../../models/Assignment';
import { AssignmentService } from '../../../Services/assignment.service';
import { ProjectService } from '../../../Services/project.service';

@Component({
  selector: 'app-mytasks',
  templateUrl: './mytasks.component.html',
  styleUrls: ['./mytasks.component.scss']
})
export class MytasksComponent {

  projects: any;
  myTasks: any;

  constructor(private projectService: ProjectService, private assignmentService: AssignmentService) { }
  ngOnInit(): void {
    this.projectService.getParticipations().subscribe(
      (data) => {
        this.projects = data;
      }
    )
  }

  getUserAssignments(projectId: number) {
    this.assignmentService.getUserAssignments(projectId).subscribe(
      (data) => {
        this.myTasks = data;
      }
    );
  }

  updateState(state: Assignment) {    
    this.assignmentService.updateAssignment(state).subscribe(
      (data) => {
        
      }
    );
  }

}
