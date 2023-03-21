import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ModalService {

  private modalOpen = new Subject<boolean>();
  private modalError = new Subject<string>();
  private modalSuccess = new Subject<string>();

  constructor() { }

  openModal() {
    this.modalOpen.next(true);
  }

  closeModal() {
    this.modalOpen.next(false);
    this.setModalError("");
    this.setModalSuccess("");
  }

  getModalOpen() {
    return this.modalOpen.asObservable();
  }

  getModalError() {
    return this.modalError.asObservable();
  }

  getModalSuccess() {
    return this.modalSuccess.asObservable();
  }

  setModalError(message: string) {
    this.modalError.next(message);
    this.modalSuccess.next("");
  }

  setModalSuccess(message: string) {
    this.modalSuccess.next(message);
    this.modalError.next("");
  }
}
