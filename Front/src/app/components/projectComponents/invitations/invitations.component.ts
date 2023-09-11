import { Component, Input } from '@angular/core';
import { InvitationsService } from 'src/app/Services/invitations.service';
import { ResponseService } from 'src/app/Services/response.service';

@Component({
  selector: 'app-invitations',
  templateUrl: './invitations.component.html',
  styleUrls: ['./invitations.component.scss']
})
export class InvitationsComponent {
  @Input() invitations: any;

  constructor(
    private invitationsService: InvitationsService,
    private responseService: ResponseService
  ) { }

  ngOnInit(): void {
    this.invitationsService.getInvitations().subscribe(
      (res) => {
        this.invitations = res;
      }
    );
  }

  acceptInvitation(invitation: any) {
    this.invitationsService.acceptInvitation(invitation?.id).subscribe(
      (res) => {
        this.responseService.showSuccess("Invitation accepted successfully");
        this.invitations = this.invitations.filter((inv: any) => inv.id != invitation.id);
      },
      (err) => {
        this.responseService.showErrors(err);
      }
    );
  }

  rejectInvitation(invitation: any) {
    this.invitationsService.declineInvitation(invitation?.id).subscribe(
      (res) => {
        this.responseService.showSuccess("Invitation declined successfully");
        this.invitations = this.invitations.filter((inv: any) => inv.id != invitation.id);
      },
      (err) => {
        this.responseService.showErrors(err);
      }
    );
  }

}
