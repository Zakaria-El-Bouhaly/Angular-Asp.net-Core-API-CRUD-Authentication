import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpService } from './http.service';

@Injectable({
  providedIn: 'root'
})
export class InvitationsService {

  constructor(private httpService: HttpService) { }


  getInvitations(): Observable<any> {
    return this.httpService.get('/invitations');
  }

  acceptInvitation(invitationId: string): Observable<any> {
    return this.httpService.delete('/invitations/accept/' + invitationId);
  }

  declineInvitation(invitationId: string): Observable<any> {
    return this.httpService.delete('/invitations/reject/' + invitationId);
  }


}
