import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { AuthService } from 'src/app/Services/auth.service';

@Component({
  selector: 'app-forgot-password',
  templateUrl: './forgot-password.component.html',
  styleUrls: ['./forgot-password.component.scss']
})
export class ForgotPasswordComponent {

  forgotPasswordForm!: FormGroup;
  errorMsg: string = "";
  successMsg: string = "";

  constructor(private authService: AuthService) { }

  ngOnInit(): void {
    this.forgotPasswordForm = new FormGroup({
      "email": new FormControl("", Validators.required)
    }
    );
  }

  onResetSubmit() {
    this.authService.forgotPassword(this.forgotPasswordForm.value).subscribe({
      next: (res) => {
        this.successMsg = res.message;
        this.errorMsg = "";
      },
      error: (err) => {
        this.errorMsg = err.error.message;
        this.successMsg = "";
      }
    });
  }


}
