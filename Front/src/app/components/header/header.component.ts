import { Component } from '@angular/core';
import { AuthService } from 'src/app/Services/auth.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent {
  title = 'Home';

  constructor(private authSrv: AuthService) { }

  islogged = this.authSrv.loggedIn();
  
  // subscribe to the event emitter
  
  ngOnInit() {
    this.authSrv.AuthEvent.subscribe((data) => {
      this.islogged = data;
    });
  }


  logout() {
    this.authSrv.logout();
  }
}
