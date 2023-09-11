import { Component, EventEmitter, Input, Output, SimpleChanges } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { confirmPasswordValidator } from 'src/app/helpers/CustomValidators';

import { UsersService } from 'src/app/Services/users.service';

@Component({
  selector: 'app-full-user-form',
  templateUrl: './full-user-form.component.html',
  styleUrls: ['./full-user-form.component.scss']
})
export class FullUserFormComponent {

  myForm!: FormGroup;
  selectedFile!: File;
  @Output() submitForm = new EventEmitter();
  @Input() user!: any;

  userRoles:any =[
    {id:true, name:"Admin"},
    {id:false, name:"User"}
  ]

  constructor() { }

  ngOnInit(): void {
    this.myForm = new FormGroup({
      id: new FormControl(this.user.id),
      name: new FormControl(this.user.name),
      email: new FormControl(this.user.email, [Validators.email]),      
      password: new FormControl("", [Validators.minLength(6)]),
      confirmPassword: new FormControl("", [Validators.minLength(6), confirmPasswordValidator('password', 'confirmPassword')]),
      isAdmin: new FormControl(this.user.isAdmin, [Validators.pattern("true|false")])
    }

    );

  }

  ngOnChanges(changes: SimpleChanges) {
    if (changes['user'] && this.myForm) {
      this.myForm.setValue({
        id: this.user.id,
        name: this.user.name,        
        email: this.user.email,
        password: "",
        confirmPassword: "",
        isAdmin: this.user.isAdmin
      }
      );
    }
  }

  onFileSelected(event: any) {
    const file: File = event.target.files[0];
    this.selectedFile = file;
  }


  onSubmit() {
    const formData = new FormData();
    formData.append('id', this.myForm.value.id);
    formData.append('name', this.myForm.value.name);
    formData.append('email', this.myForm.value.email);
    formData.append('profilePicture', this.selectedFile);
    formData.append('password', this.myForm.value.password);
    formData.append('confirmPassword', this.myForm.value.confirmPassword);
    formData.append('isAdmin', this.myForm.value.isAdmin);
    this.submitForm.emit(formData);
  }
}
