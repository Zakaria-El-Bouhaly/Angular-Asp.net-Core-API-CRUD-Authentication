import { Component } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { NavigationEnd, Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {

  constructor(private titleService: Title, private router: Router) { }
  adminPage: Boolean = false;
  url: string = "hello";
  ngOnInit() {
    this.titleService.setTitle("Colab");
    this.router.events.subscribe((val) => {
      if (val instanceof NavigationEnd) {
        this.url = val.url;
       
        if (this.url.includes("/admin")) {
          this.adminPage = true;
        } else {
          this.adminPage = false;
        }
      }
      
    });
  }



}
