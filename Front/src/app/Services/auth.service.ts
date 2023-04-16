import { EventEmitter, Injectable, Output } from '@angular/core';
import { Router } from '@angular/router';
import { JwtHelperService } from '@auth0/angular-jwt';
import { Observable, Subject } from 'rxjs';
import { HttpService } from './http.service';
import { User } from '../models/User';

@Injectable({
  providedIn: 'root'
})
export class AuthService {


  constructor(private router: Router, private httpService: HttpService) { }


  AuthEvent: Subject<boolean> = new Subject<boolean>();
  

  login(user: User): Observable<any> {
    return this.httpService.post('/Auth/login', user);
  }

  loginWithGoogle(credentials: any): Observable<any> {

    return this.httpService.post('/Auth/loginWithGoogle', credentials);
  }

  loginSuccess(res: any) {
    localStorage.setItem('user', JSON.stringify(res.user));
    localStorage.setItem('token', res.token);
    this.AuthEvent.next(true);    
  }

  register(user: User): Observable<any> {
    return this.httpService.post('/Auth/register', user);
  }


  loggedIn(): boolean {

    const helper = new JwtHelperService();
    const token = this.gettoken();
    if (token) {
      return !helper.isTokenExpired(token);
    }
    return false;
  }

  isAdmin(): boolean {
    const user = JSON.parse(localStorage.getItem('user') || '{}');
    return user.isAdmin;
  }

  gettoken() {
    return localStorage.getItem('token') || '';
  }

  logout() {
    localStorage.removeItem('token');
    localStorage.removeItem('user');
    this.AuthEvent.next(false);    
  }

  getUserId() {
    return JSON.parse(localStorage.getItem('user') || '{}').id;
  }

  sendVerificationEmail(): Observable<any> {
    return this.httpService.post('/user/sendVerificationEmail', {});
  }

  verifyEmail(formData: any): Observable<any> {
    return this.httpService.post('/user/verifyEmail', formData);
  }

  forgotPassword(formData: any): Observable<any> {
    return this.httpService.post('/user/forgotPassword', formData);
  }

  resetPassword(formData: any): Observable<any> {
    return this.httpService.post('/user/resetPassword', formData);
  }
}
