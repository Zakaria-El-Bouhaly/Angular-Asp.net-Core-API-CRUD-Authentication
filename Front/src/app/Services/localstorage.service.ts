import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class LocalstorageService {

  constructor() { }

  userSubj = new Subject();

  getUser() {
    this.userSubj.next(JSON.parse(localStorage.getItem('user') || '{}'));
  }
}
