import { Component, EventEmitter, Input, Output } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { AssignmentService } from 'src/app/Services/assignment.service';
import { ModalService } from 'src/app/Services/modal.service';

@Component({
  selector: 'app-asignmts-list',
  templateUrl: './asignmts-list.component.html',
  styleUrls: ['./asignmts-list.component.scss']
})
export class AsignmtsListComponent {
  @Input() allAssignments: any[] = [];
  @Output() onDeletedAssignment: EventEmitter<any> = new EventEmitter<any>();
  assignment: any;
  modalTitle: string = "Edit Assignment";
  isForm: boolean = false;
  projectId: any;


  constructor(private assignmentService: AssignmentService, private modalService: ModalService, private route: ActivatedRoute) { }

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
  }

  closeModal() {
    this.modalService.closeModal();
  }


  updateAsg(assignment: any) {
    this.assignmentService.updateAssignment(assignment).subscribe({
      next: (res) => {
        this.modalService.setModalSuccess("Assignment updated successfully");
        console.log(res);
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
        this.modalService.setModalError("Error updating assignment");
      }
    });
  }

  deleteAssignment() {
    console.log(this.assignment.id);
    this.assignmentService.deleteAssignment(this.assignment.id).subscribe({
      next: (res) => {
        this.modalService.setModalSuccess("Assignment deleted successfully");
        this.onDeletedAssignment.emit(this.assignment.id);
      },
      error: (err) => {
        this.modalService.setModalError("Error deleting assignment");
      }
    });
  }


  addAsgnt(assignment: any) {
    this.assignmentService.addAssignment(assignment).subscribe({
      next: (res) => {
        this.modalService.setModalSuccess("Assignment added successfully");
        console.log(res);
        delete res.project;
        this.allAssignments.push(res);
      },
      error: (err) => {
        this.modalService.setModalError("Error adding assignment");
      }
    });
  }




}
