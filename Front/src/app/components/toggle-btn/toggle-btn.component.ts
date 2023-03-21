import { Component } from '@angular/core';

@Component({
  selector: 'app-toggle-btn',
  templateUrl: './toggle-btn.component.html',
  styleUrls: ['./toggle-btn.component.scss']
})
export class ToggleBtnComponent {

  editMode = false;
  
  

  toggle() {
    this.editMode = !this.editMode;  
  }
}
