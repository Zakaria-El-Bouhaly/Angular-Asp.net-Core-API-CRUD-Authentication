import { Injectable } from '@angular/core';
import { HttpService } from './http.service';

@Injectable({
  providedIn: 'root'
})
export class UsersService {

  constructor(private httpService: HttpService) { }

  getUsers() {
    return this.httpService.get('/user');
  }


  updateUser(id: any, user: any) {
    return this.httpService.put(`/user/${id}`, user);
  }

  deleteUser(id: any) {
    return this.httpService.delete(`/user/${id}`);
  }

  searchUsers(query: string) {
    return this.httpService.get(`/user/search?query=${query}`);
  }
}
