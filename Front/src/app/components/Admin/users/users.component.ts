import { Component } from '@angular/core';
import { ModalService } from 'src/app/Services/modal.service';
import { UsersService } from 'src/app/Services/users.service';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.scss']
})
export class UsersComponent {
  users: any = [];
  isForm: boolean = false;
  modalTitle: string = "Edit User";
  user: any;
  usersColumns: any = [];
  constructor(private usersService: UsersService, private modalService: ModalService) {

  }
  ngOnInit(): void {
    this.usersService.getUsers().subscribe((res: any) => {


      res.forEach((user: any) => {

        delete user.profilePicture;
        delete user.participations;

      });

      this.users = res;

      console.log(this.users);

      this.usersColumns = Object.keys(this.users[0]);

    });
  }


  openEditModal(user: any) {
    this.isForm = true;
    this.modalTitle = "Edit User";
    this.user = user;
    this.modalService.openModal();
  }

  openDeleteModal(user: any) {
    this.isForm = false;
    this.modalTitle = "Delete User";
    this.user = user;
    this.modalService.openModal();
  }

  submitForm(user: any) {
    this.updateUser(user);

  }

  updateUser(user: any) {
    this.usersService.updateUser(user.get('id'), user).subscribe({
      next: (res: any) => {
        delete res.participations;
        delete res.profilePicture;
        this.users = this.users.map((u: any) => {
          if (u.id === res.id) {
            return res;
          }
          return u;
        });
        this.modalService.setModalSuccess("User updated successfully");
      },
      error: (err: any) => {
        this.modalService.setModalError("Error updating user");
      }
    }
    );
  }

  deleteUser() {
    console.log(this.user);
    this.usersService.deleteUser(this.user.id).subscribe({
      next: (res: any) => {
        this.users = this.users.filter((u: any) => u.id !== this.user.id);
        this.modalService.setModalSuccess("User deleted successfully");
      },
      error: (err: any) => {
        this.modalService.setModalError("Error deleting user");
      }
    });

  }
}