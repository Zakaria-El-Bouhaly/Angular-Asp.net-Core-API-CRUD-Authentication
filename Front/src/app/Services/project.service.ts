import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpService } from './http.service';
@Injectable({
  providedIn: 'root'
})
export class ProjectService {

  constructor(private httpService: HttpService) { }

  getProjects(): Observable<any> {
    return this.httpService.get("/project");
  }

  getUserProjects(id: number): Observable<any> {
    return this.httpService.get("/project/user/" + id);
  }

  getProjectById(id: number): Observable<any> {
    return this.httpService.get("/project/" + id);
  }

  addProject(project: any): Observable<any> {
    return this.httpService.post("/project", project);
  }

  deleteProject(id: number): Observable<any> {
    return this.httpService.delete("/project/" + id);
  }

  updateProject(project: any): Observable<any> {
    return this.httpService.put("/project/"+project.id, project);
  }

  getParticipations():Observable<any>{
    return this.httpService.get('/project/participations');
  }

}
