import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { AuthService } from 'src/app/Services/auth.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent {


  constructor(private authSrv: AuthService, private router: Router, private route: ActivatedRoute) { }

  islogged = this.authSrv.loggedIn();
  sub1!: Subscription;
  sub2!: Subscription;



  // subscribe to the event emitter

  ngOnInit() {
    this.sub1 = this.authSrv.AuthEvent.subscribe((data) => {
      this.islogged = data;
    });
  }


  logout() {
    this.authSrv.logout();
    this.router.navigate(['/login']);
  }

  ngOnDestroy() {
    this.sub1.unsubscribe();
  }
}
