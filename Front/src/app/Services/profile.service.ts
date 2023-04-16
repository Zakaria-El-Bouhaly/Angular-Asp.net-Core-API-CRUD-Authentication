import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpService } from './http.service';

@Injectable({
  providedIn: 'root'
})
export class ProfileService {

  constructor(private httpService: HttpService) {    
  }

  getProfile(): Observable < any > {
    return this.httpService.get("/profile");
  }

  updateProfile(formData: any): Observable < any > {
    return this.httpService.put("/profile", formData);
  }

  updateEmail(emailForm: any): Observable < any > {
    return this.httpService.put("/profile/email", emailForm);
  }
  
  updatePassword(passwordForm: any): Observable < any > {
    return this.httpService.put("/profile/password", passwordForm);
  }    
}
