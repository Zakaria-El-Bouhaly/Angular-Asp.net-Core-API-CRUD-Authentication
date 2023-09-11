import { Component, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthService } from 'src/app/Services/auth.service';
import { ResponseService } from 'src/app/Services/response.service';



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
  isLoading: boolean = false;

  @ViewChild('authForm') authForm!: NgForm;

  constructor(private authService: AuthService, private route: ActivatedRoute, private router: Router,
    private responseService: ResponseService
    ) { }

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
    if (!this.authForm.valid) {
      return;
    }

    
    this.isLoading = true;
    if (this.isloginMode) {


      var loginUser = { 'email': this.authForm.value.email, 'password': this.authForm.value.password };
      this.authService.login(loginUser).subscribe({
        next: (res) => {
          this.isLoading = false;
          this.authService.loginSuccess(res);
          if (this.authService.isAdmin()) {
            this.router.navigate(['/admin']);
          }
          else {
            this.router.navigate(['/']);
          }
        },
        error: (err) => {
          this.isLoading = false;
          this.responseService.showErrors(err);
        }
      }
      );


    }
    else {
      this.authService.register(this.authForm.value).subscribe({
        next: (res) => {
          this.isLoading = false;
          this.redirectToLogin();
        },
        error: (err) => {
          this.isLoading = false;
          this.responseService.showErrors(err);
        }
      });

    }
  }

  redirectToLogin() {
    this.message = "Registration successful, an email has been sent to your email address, please verify your email address to login";
    this.router.navigate(['/login'], { queryParams: { message: this.message } });
  }

  onGoogleLogin(response: any) {
    var googleCredentials = { 'credential': response.credential };
    
    this.authService.loginWithGoogle(googleCredentials).subscribe({
      next: (res) => {
        
        this.authService.loginSuccess(res);
        this.router.navigate(['/']);
      },
      error: (err) => {
        
        this.responseService.showErrors(err);
      }
    })
  }

  ngonDestory() {
    this.subscription.unsubscribe();
  }
}