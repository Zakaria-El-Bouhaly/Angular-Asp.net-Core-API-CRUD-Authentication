import { HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import Swal from 'sweetalert2';

@Injectable({
  providedIn: 'root',
})
export class ResponseService {
  constructor(private router: Router) {}

  //Méthode de gestion des erreurs en fonction des codes erreurs
  getErrorMessage(error: HttpErrorResponse): string {
    let msgResponse = '';
    if (error.status == 500) {
      return 'Internal Server Error';
    }
    let errors = error?.error?.errors;
    if (errors == undefined || errors == null) {
      msgResponse = "an error has occurred"
    }
    else if (errors?.length != undefined) {
      msgResponse = errors;
    } else {
      Object?.keys(errors).forEach((key) => {
        errors[key].forEach((message: string) => {
          msgResponse += message + '\n';
        });
      });
    }
    return msgResponse;
  }

  showErrors(error: HttpErrorResponse) {
    let msg = this.getErrorMessage(error);
    this.DisplayError(msg, 'error', 'Error', true, null);
  }

  showSuccess(message: string, confirm: boolean = false, timer: any = '2000') {
    this.DisplayError(message, 'success', 'Success', confirm, timer);
  }
  //Méthode qui permet d'afficher un message d'erreur
  DisplayError(
    text: string,
    type: any,
    titre: string,
    confirm: boolean = false,
    timer: any = '2000'
  ) {
    Swal.fire({
      icon: type,
      title: titre,
      text: text,
      showConfirmButton: confirm,
      timer: timer,
    });
  }

  displayInfos(title: string) {
    Swal.fire({
      title: title,
      showClass: {
        popup: 'animate__animated animate__fadeInDown',
      },
      hideClass: {
        popup: 'animate__animated animate__fadeOutUp',
      },
    });
  }
}
