import { Component } from '@angular/core';
import { ProfileService } from 'src/app/Services/profile.service';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.scss']
})
export class ProfileComponent {

  profile: any = { name: "", profilePicture: "", email: "" };
  errors: any = { profile: "", email: "", password: "" };
  response: any = { profile: "", email: "", password: "" };

  constructor(private profileService: ProfileService) { }
  ngOnInit() {
    
    this.profileService.getProfile().subscribe(
      {
        next: (data) => {          
          this.profile = data;
        }
      }
    );
  }

  updateProfile(form: any) {
    
    this.profileService.updateProfile(form).subscribe(
      {
        next: (data) => {
          this.setResponse('profile', 'Profile updated successfully', data);
        },
        error: (err) => {
          this.setErrors('profile', err.error.errors);
        }
      }
    );
  }

  updateEmail(form: any) {
    this.profileService.updateEmail(form).subscribe(
      {
        next: (data) => {
          this.setResponse('email', 'Email updated successfully', data);
        },
        error: (err) => {
          this.setErrors('email', err.error.errors);
        }
      }
    );
  }

  updatePassword(form: any) {
    this.profileService.updatePassword(form).subscribe(
      {
        next: (data) => {
          this.setResponse('password', 'Password updated successfully', data);
        },
        error: (err) => {
          this.setErrors('password', err.error.errors);
        }
      }
    );
  }

  setResponse(key: string, value: string, profile: any) {
    this.response[key] = value;
    this.errors[key] = "";
    this.profile = profile;
  }

  setErrors(key: string, value: string) {
    this.errors[key] = value;
    this.response[key] = "";
  }
}
