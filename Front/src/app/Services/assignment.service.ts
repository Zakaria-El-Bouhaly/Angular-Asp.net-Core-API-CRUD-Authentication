import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpService } from './http.service';

@Injectable({
  providedIn: 'root'
})
export class AssignmentService {

  constructor(private httpService: HttpService) { }

  updateAssignment(assignment: any): Observable<any> {
    return this.httpService.put('/assignment', assignment);
  }

  deleteAssignment(assignmentId: any): Observable<any> {
    return this.httpService.delete('/assignment/' + assignmentId);
  }

  addAssignment(assignment: any): Observable<any> {
    return this.httpService.post('/assignment', assignment);
  }

  getUserAssignments(projectId: number): Observable<any> {
    return this.httpService.get('/assignment/usertasks/' + projectId);
  }

  
  
}
