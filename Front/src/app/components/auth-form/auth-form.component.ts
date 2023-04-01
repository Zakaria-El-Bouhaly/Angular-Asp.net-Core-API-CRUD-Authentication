import { Component, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthService } from 'src/app/Services/auth.service';



@Component({
  selector: 'app-auth-form',
  templateUrl: './auth-form.component.html',
  styleUrls: ['./auth-form.component.scss']
})
export class AuthFormComponent {

  isloginMode = true;
  title!: string;
  message: string = '';
  errors: any = "";
  subscription: any;
  userInfo: any;

  @ViewChild('authForm') authForm!: NgForm;

  constructor(private authService: AuthService, private route: ActivatedRoute, private router: Router) { }

  ngOnInit(): void {
    this.subscription = this.route.data.subscribe(data => {
      this.isloginMode = data['isLoginMode'];
      this.title = data['title'];
      // get query params
      this.route.queryParams.subscribe(params => {
        this.message = params['message'];
      });
    });
  }



  onSubmited() {

    console.log(this.authForm.value);

    if (this.isloginMode) {
      var loginUser = { 'email': this.authForm.value.email, 'password': this.authForm.value.password };

      this.authService.login(loginUser).subscribe({
        next: (res) => {
          this.authService.loginSuccess(res);
          this.router.navigate(['/myprojects']);
        },
        error: (err) => {
          this.errors = err.error.errors;
        }
      }
      );


    }
    else {
      this.authService.register(this.authForm.value).subscribe({
        next: (res) => {
          this.redirectToLogin();
        },
        error: (err) => {
          this.errors = err.error.errors;
        }
      });

    }
  }

  redirectToLogin() {
    this.message = "Registration successful, please login";
    this.router.navigate(['/login'], { queryParams: { message: this.message } });
  }

  onGoogleLogin(response: any) {
    var googleCredentials = { 'credential': response.credential };
    console.log(response);
    this.authService.loginWithGoogle(googleCredentials).subscribe({
      next: (res) => {
        console.log("resutlt :" + res);
        this.authService.loginSuccess(res);
        this.router.navigate(['/myprojects']);
      },
      error: (err) => {
        this.errors = err.error.errors;
      }
    })
  }

  ngonDestory() {
    this.subscription.unsubscribe();
  }
}