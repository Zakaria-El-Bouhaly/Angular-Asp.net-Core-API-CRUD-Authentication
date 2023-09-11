import { Component, EventEmitter, Input, Output, SimpleChanges } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { environment } from 'envirement';
import { UsersService } from 'src/app/Services/users.service';

@Component({
  selector: 'app-user-form',
  templateUrl: './user-form.component.html',
  styleUrls: ['./user-form.component.scss']
})
export class UserFormComponent {


  myForm!: FormGroup;
  @Output() submitForm = new EventEmitter();
  @Input() formUserProject: any;
  @Input() isUpdateMode = false;
  participators: any = []

  userStatus: any = [
    { value: true, label: "Owner" },
    { value: false, label: "Participant" }
  ];

  mediaUrl: string = environment.socketUrl;

  searchForm: FormGroup = new FormGroup({
    userquery: new FormControl('', [Validators.required, Validators.minLength(3)])
  });


  constructor(
    private userService: UsersService
  ) { }

  ngOnInit(): void {
    this.myForm = new FormGroup({
      userId: new FormControl(this.formUserProject.userId),
      projectId: new FormControl(this.formUserProject.projectId),
      isOwner: new FormControl(this.formUserProject.isOwner, Validators.required)
    });
  }

  ngOnChanges(changes: SimpleChanges) {
    if (changes['formUserProject'] && this.myForm) {
      this.myForm.setValue({
        userId: this.formUserProject.userId,
        projectId: this.formUserProject.projectId,
        isOwner: this.formUserProject.isOwner
      }
      );
    }
  }



  searchUsers() {
    if (this.searchForm.invalid) {
      return;
    }
    this.userService.searchUsers(this.searchForm.value.userquery).subscribe((res: any) => {
      this.participators = res;
    })
  }

  onSubmit() {
    this.submitForm.emit(this.myForm.value);
  }
}
