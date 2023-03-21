import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ProjectUser } from '../models/ProjectUser';
import { HttpService } from './http.service';

@Injectable({
  providedIn: 'root'
})
export class ProjectUserService {

  constructor(private httpService: HttpService) { }

  AddUserToProject(projectUser: ProjectUser): Observable<any> {
    return this.httpService.post('/project/addUser', projectUser);
  }

  RemoveUserFromProject(projectUser: ProjectUser): Observable<any> {
    return this.httpService.post('/project/removeUser', projectUser)
  }

  UpdateUserInProject(projectUser: ProjectUser): Observable<any> {
    return this.httpService.put('/project/updateUser', projectUser);
  }

}
