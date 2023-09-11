import { Component, EventEmitter, Input, Output } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { AssignmentService } from 'src/app/Services/assignment.service';
import { ModalService } from 'src/app/Services/modal.service';
import { ResponseService } from 'src/app/Services/response.service';

@Component({
  selector: 'app-asignmts-list',
  templateUrl: './asignmts-list.component.html',
  styleUrls: ['./asignmts-list.component.scss']
})
export class AsignmtsListComponent {
  @Input() allAssignments: any[] = [];
  @Input() participators: any[] = [];

  @Output() onAction: EventEmitter<any> = new EventEmitter<any>();
  assignment: any;
  modalTitle: string = "Edit Assignment";
  isForm: boolean = false;
  projectId: any;
  asgnmtStates: string[] = ["To Do", "In Progress", "Done"];


  constructor(private respoService: ResponseService,
    private assignmentService: AssignmentService, private modalService: ModalService, private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.projectId = this.route.snapshot.paramMap.get('id');
  }


  openEditModal(assignment: any) {
    this.isForm = true;
    this.modalTitle = "Edit Assignment";
    this.assignment = assignment;
    this.modalService.openModal();
  }

  openAddModal() {
    this.isForm = true;
    this.modalTitle = "Add Assignment";
    this.assignment = {
      id: 0,
      projectId: this.projectId,
      userId: 0,
      title: "",
      description: "",
      state: 0
    };

    this.modalService.openModal();

  }

  openDeleteModal(assignment: any) {
    this.isForm = false;
    this.modalTitle = "Delete Assignment";
    this.assignment = assignment;
    this.modalService.openModal();
  }

  submitForm(assignment: any) {
    if (assignment.id == 0) {
      this.addAsgnt(assignment);
    }
    else {
      this.updateAsg(assignment);
    }
    this.onAction.emit(this.allAssignments);
  }

  closeModal() {
    this.modalService.closeModal();
  }


  updateAsg(assignment: any) {
    this.assignmentService.updateAssignment(assignment).subscribe({
      next: (res) => {
        this.modalService.setModalSuccess("Assignment updated successfully");
        
        this.allAssignments.forEach((asg) => {
          if (asg.id == assignment.id) {
            asg.title = res.title;
            asg.description = res.description;
            asg.userId = res.userId;
            asg.state = res.state;
            asg.updatedAt = res.updatedAt;
            asg.projectId = res.projectId;
          }
        });
      },
      error: (err) => {
        let errors = this.respoService.getErrorMessage(err);
        this.modalService.setModalError(errors);
      }
    });
  }

  deleteAssignment() {
    
    this.assignmentService.deleteAssignment(this.assignment.id).subscribe({
      next: (res) => {
        this.modalService.setModalSuccess("Assignment deleted successfully");
        this.allAssignments = this.allAssignments.filter((asg) => asg.id != this.assignment.id);
        this.onAction.emit(this.allAssignments);
      },
      error: (err) => {
        let errors = this.respoService.getErrorMessage(err);
        this.modalService.setModalError(errors);
      }
    });
  }


  addAsgnt(assignment: any) {
    this.assignmentService.addAssignment(assignment).subscribe({
      next: (res) => {
        this.modalService.setModalSuccess("Assignment added successfully");
        
        delete res.project;
        this.allAssignments.push(res);
      },
      error: (err) => {
        let errors = this.respoService.getErrorMessage(err);
        this.modalService.setModalError(errors);
      }
    });
  }




}
