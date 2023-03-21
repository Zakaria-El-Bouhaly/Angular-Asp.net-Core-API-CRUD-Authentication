import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Project } from '../../../models/Project';

@Component({
  selector: 'project-item',
  templateUrl: './project-item.component.html',
  styleUrls: ['./project-item.component.scss']
})
export class ProjectItemComponent {
  @Input() project: Project = { id: 0, title: '', description: '', createdAt: new Date(), updatedAt: new Date() };  
  @Output() deleteEvent = new EventEmitter<Project>();
  @Output() editEvent = new EventEmitter<Project>();

  constructor() { }

  delete(project: Project) {
    this.deleteEvent.emit(project);
  }

  edit(project: Project) {
    this.editEvent.emit(project);
  }

}
