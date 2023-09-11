import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-select-input',
  templateUrl: './select-input.component.html',
  styleUrls: ['./select-input.component.scss']
})
export class SelectInputComponent {
  @Input() items!: any[] ;
  @Input() label!: string ;
  @Input() Idkey!: string ;
  @Input() text!: string ;
  @Output() itemSelected = new EventEmitter();

  constructor() { }

  onItemSelect(item: any) {
    if (item) {
      this.itemSelected.emit(item.target.value);
      
    }
  }
  
}
