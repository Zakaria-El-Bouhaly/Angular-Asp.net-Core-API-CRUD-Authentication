import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthService } from 'src/app/Services/auth.service';


@Component({
  selector: 'app-email-verif',
  templateUrl: './email-verif.component.html',
  styleUrls: ['./email-verif.component.scss']
})
export class EmailVerifComponent {

  successMsg: string = "";
  errorMsg: string = "";

  constructor(private route: ActivatedRoute, private authService: AuthService) { }



  ngOnInit() {
    this.route.queryParams.subscribe(params => {
      const form = { "token": params['token'] };
      this.authService.verifyEmail(form).subscribe({
        next: (res) => {
          this.successMsg = res.message;
        },
        error: (err) => {
          
          this.errorMsg = err.error.message;
        }
      });
    }
    );
  }

}
