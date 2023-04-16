import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { confirmPasswordValidator } from 'src/app/helpers/CustomValidators';
import { AuthService } from 'src/app/Services/auth.service';

@Component({
  selector: 'app-reset-password',
  templateUrl: './reset-password.component.html',
  styleUrls: ['./reset-password.component.scss']
})
export class ResetPasswordComponent {





  passwordResetForm!: FormGroup;
  errorMsg: string = "";
  successMsg: string = "";

  constructor(private authService: AuthService, private route: ActivatedRoute) { }

  ngOnInit(): void {

    this.passwordResetForm = new FormGroup({
      "token": new FormControl("", Validators.required),
      "password": new FormControl("", Validators.required),
      "confirmPassword": new FormControl("", [Validators.required, Validators.minLength(6)]),
    }
    );

    this.route.queryParams.subscribe(params => {
      this.passwordResetForm.patchValue({ token: params['token'] });
    }
    );

  }

  onResetSubmit() {
    this.authService.resetPassword(this.passwordResetForm.value).subscribe({
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