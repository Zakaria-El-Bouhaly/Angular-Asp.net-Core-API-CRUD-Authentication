import { Component, EventEmitter, Output } from '@angular/core';
import { environment } from 'envirement';
import { CredentialResponse, PromptMomentNotification } from 'google-one-tap';

@Component({
  selector: 'app-google-sign-in-btn',
  templateUrl: './google-sign-in-btn.component.html',
  styleUrls: ['./google-sign-in-btn.component.scss']
})
export class GoogleSignInBtnComponent {

  private clientId = environment.google.clientId;
  // event to be emitted when the user is logged in
  @Output() loggedInWithGoogle = new EventEmitter<CredentialResponse>();

  constructor() { }

  ngOnInit(): void {
    // @ts-ignore
    window.onGoogleLibraryLoad = () => {
      // @ts-ignore
      google.accounts.id.initialize({
        client_id: this.clientId,
        callback: this.handleCredentialResponse.bind(this),
        auto_select: false,
        cancel_on_tap_outside: true
      });
      // @ts-ignore
      google.accounts.id.renderButton(
        // @ts-ignore
        document.getElementById("buttonDiv"),
        { theme: "outline", size: "large", width: "100%" }
      );
      // @ts-ignore
      google.accounts.id.prompt((notification: PromptMomentNotification) => { });
    };
  }

  async handleCredentialResponse(response: CredentialResponse) {
    
    if (response.credential) {
      this.loggedInWithGoogle.emit(response);
    }
  }

}