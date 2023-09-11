import { Component, EventEmitter, Input, Output } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ModalService } from 'src/app/Services/modal.service';
import { ProjectUserService } from 'src/app/Services/project-user.service';
import { ResponseService } from 'src/app/Services/response.service';


@Component({
  selector: 'app-users-list',
  templateUrl: './users-list.component.html',
  styleUrls: ['./users-list.component.scss']
})
export class UsersListComponent {
  @Input() participators: any[] = [];
  @Output() onAction: EventEmitter<any> = new EventEmitter<any>();
  projectUser: any;
  modalTitle: string = "Edit participant";
  formId: number = 0;
  projectId: any;
  isEditMode = false;
  isUpdateMode: boolean = false;



  constructor(private projectUserService: ProjectUserService, private modalService: ModalService, private route: ActivatedRoute,
    private responseService: ResponseService
  ) { }

  ngOnInit(): void {
    this.projectId = this.route.snapshot.paramMap.get('id');
  }


  openEditModal(projectUser: any) {
    this.isEditMode = true;
    this.formId = 1;
    this.modalTitle = "Edit participant";
    this.projectUser = projectUser;
    this.isUpdateMode = true;
    this.modalService.openModal();

  }

  openAddModal() {
    this.isEditMode = false;
    this.formId = 1;
    this.modalTitle = "Add participant";
    this.projectUser = {
      projectId: this.projectId,
      userId: 0,
      isOwner: false
    };
    this.isUpdateMode = false;
    this.modalService.openModal();

  }

  openDeleteModal(projectUser: any) {
    this.formId = 2;
    this.modalTitle = "Delete participant";
    this.projectUser = projectUser;
    this.modalService.openModal();
  }

  closeModal() {
    this.modalService.closeModal();
  }

  submitForm(projectUser: any) {
    if (this.isEditMode) {
      this.updateUser(projectUser);
    }
    else {
      this.addUser(projectUser);
    }
  }


  updateUser(projectUser: any) {
    this.projectUserService.UpdateUserInProject(projectUser).subscribe({
      next: (res) => {
        this.modalService.setModalSuccess("participant updated successfully");
        
        this.participators.forEach((p) => {
          if (p.userId == res.userId && p.projectId == res.projectId) {
            p.isOwner = res.isOwner;
          }
        });
        this.onAction.emit(this.participators);
      },
      error: (err) => {
        let errors = this.responseService.getErrorMessage(err);
        this.modalService.setModalError(errors);
      }
    });
  }

  removeUser() {
    this.projectUserService.RemoveUserFromProject(this.projectUser).subscribe({
      next: (res) => {
        this.modalService.setModalSuccess("Participant deleted successfully");
        this.participators = this.participators.filter((p) => p.userId != res?.userId);

        this.onAction.emit(this.participators);
      },
      error: (err) => {
        let errors = this.responseService.getErrorMessage(err);
        this.modalService.setModalError(errors);
      }
    });
  }


  addUser(projectUser: any) {
    this.projectUserService.AddUserToProject(projectUser).subscribe({
      next: (res) => {
        this.modalService.setModalSuccess("Invitation sent successfully");                
      },
      error: (err) => {
        let errors = this.responseService.getErrorMessage(err);
        this.modalService.setModalError(errors);
      }
    });
  }


}
