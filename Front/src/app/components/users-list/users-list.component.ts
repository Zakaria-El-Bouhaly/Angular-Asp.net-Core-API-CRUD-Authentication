import { Component, Input } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ModalService } from 'src/app/Services/modal.service';
import { ProjectUserService } from 'src/app/Services/project-user.service';


@Component({
  selector: 'app-users-list',
  templateUrl: './users-list.component.html',
  styleUrls: ['./users-list.component.scss']
})
export class UsersListComponent {
  @Input() participants: any[] = [];
  projectUser: any;
  modalTitle: string = "Edit participant";
  formId: number = 0;
  projectId: any;
  isEditMode = false;


  constructor(private projectUserService: ProjectUserService, private modalService: ModalService, private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.projectId = this.route.snapshot.paramMap.get('id');
  }


  openEditModal(projectUser: any) {
    this.isEditMode = true;
    this.formId = 1;
    this.modalTitle = "Edit participant";
    this.projectUser = projectUser;
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
        console.log(res);
        this.participants.forEach((p) => {
          if (p.userId == res.userId && p.projectId == res.projectId) {
            p.isOwner = res.isOwner;
          }
        });
      },
      error: (err) => {
        this.modalService.setModalError("Error updating participant");
      }
    });
  }

  removeUser() {
    this.projectUserService.RemoveUserFromProject(this.projectUser).subscribe({
      next: (res) => {
        this.modalService.setModalSuccess("Participant deleted successfully");
        console.log(res);
        this.participants = this.participants.filter((p) => {
          return p.userId != res.userId || p.projectId != res.projectId;
        });
      },
      error: (err) => {
        this.modalService.setModalError("Error deleting participant");
      }
    });
  }


  addUser(projectUser: any) {
    this.projectUserService.AddUserToProject(projectUser).subscribe({
      next: (res) => {
        this.modalService.setModalSuccess("User added successfully");
        console.log(res);
        delete res.project;
        res.user = res.user.name
        this.participants.push(res);
      },
      error: (err) => {
        this.modalService.setModalError("Error adding user");
      }
    });
  }


}
