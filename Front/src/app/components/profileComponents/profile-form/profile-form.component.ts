import { Component, EventEmitter, Input, Output, SimpleChanges } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { environment } from 'envirement';

@Component({
  selector: 'app-profile-form',
  templateUrl: './profile-form.component.html',
  styleUrls: ['./profile-form.component.scss']
})
export class ProfileFormComponent {


  profileForm!: FormGroup;
  emailForm!: FormGroup;
  passwordForm!: FormGroup;

  @Output() onProfileUpdate = new EventEmitter();
  @Output() onEmailUpdate = new EventEmitter();
  @Output() onPasswordUpdate = new EventEmitter();

  @Input() profile: any;
  @Input() errors: any;
  @Input() response: any;

  selectedFile!: File;

  imgPath = environment.socketUrl;

  constructor() { }

  ngOnInit(): void {
    this.profileForm = new FormGroup({
      name: new FormControl(this.profile.name, [Validators.required, Validators.minLength(3)]),
      profilePicture: new FormControl(this.profile.profilePicture)
    });

    this.emailForm = new FormGroup({
      email: new FormControl(this.profile.email, [Validators.required, Validators.email]),
      currentPassword: new FormControl("", [Validators.required])
    });

    this.passwordForm = new FormGroup({
      currentPassword: new FormControl("", [Validators.required]),
      newPassword: new FormControl('', [Validators.required]),
      confirmPassword: new FormControl('', [Validators.required])
    });
  }

  ngOnChanges(changes: SimpleChanges) {
    if (changes['profile'] && this.profileForm) {
      this.profileForm.setValue({
        name: this.profile.name,
        profilePicture: this.profile.profilePicture
      });
      this.emailForm.setValue({
        email: this.profile.email,
        currentPassword: ""
      });
    }
  }

  onFileSelected(event: any) {
    this.selectedFile = event.target.files[0];
  }


  onProfileSubmit() {
    const formData = new FormData();
    formData.append('name', this.profileForm.value.name);
    if (this.selectedFile) {
      formData.append('profilePicture', this.selectedFile);
    }
    this.onProfileUpdate.emit(formData);
  }

  onEmailSubmit() {
    this.onEmailUpdate.emit(this.emailForm.value);
  }

  onPasswordSubmit() {
    this.onPasswordUpdate.emit(this.passwordForm.value);
  }
}