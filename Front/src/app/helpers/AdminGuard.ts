//auth guard service to secure the routes
import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';
import { AuthService } from '../Services/auth.service';

@Injectable({
    providedIn: 'root'
})
export class AdminGuard implements CanActivate {

    constructor(private authService: AuthService, private router: Router) { }

    canActivate(): boolean {

        if (this.authService.loggedIn() && this.authService.isAdmin()) {
            return true;
        }
        else {
            if (this.authService.gettoken()) {
                this.authService.logout();
            }
            this.router.navigate(['/login']);
            return false;
        }
    }
}