import { Component, EventEmitter, Input, Output } from '@angular/core';
import { KeyValue } from '@angular/common';


@Component({
  selector: 'app-mytable',
  templateUrl: './mytable.component.html',
  styleUrls: ['./mytable.component.scss']
})
export class MytableComponent {
  @Input() Tabledata: any;
  @Output() deleteEvent = new EventEmitter<any>();
  @Output() editEvent = new EventEmitter<any>();

  constructor() { }

  onCompare(_left: KeyValue<any, any>, _right: KeyValue<any, any>): number {
    return 1;
  }

  delete(item: any) {
    this.deleteEvent.emit(item);
  }

  edit(item: any) {
    this.editEvent.emit(item);
  }
}
