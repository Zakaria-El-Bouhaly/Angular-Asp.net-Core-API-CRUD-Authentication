import { CdkDragDrop, transferArrayItem } from '@angular/cdk/drag-drop';
import { Component, EventEmitter, Input, Output, SimpleChanges } from '@angular/core';
import { Assignment } from 'src/app/models/Assignment';

@Component({
  selector: 'app-kanban',
  templateUrl: './kanban.component.html',
  styleUrls: ['./kanban.component.scss']
})
export class KanbanComponent {

  @Input() tasks: any;
  @Output() updatedState = new EventEmitter<Assignment>();

  todo: Assignment[] = [];
  inProgress: Assignment[] = [];
  done: Assignment[] = [];

  ngOnInit(): void {
    if (this.tasks) {
      
      this.setTasks();
    }
  }

  ngOnChanges(changes: SimpleChanges) {
    if (changes['tasks'] && this.tasks) {
      this.setTasks();
    }
  }

  setTasks() {
    this.todo = [];
    this.inProgress = [];
    this.done = [];
    this.tasks.forEach((task: Assignment) => {
      if (task.state === 0) {
        this.todo.push(task);
      }
      if (task.state === 1) {
        this.inProgress.push(task);
      }
      if (task.state === 2) {
        this.done.push(task);
      }
    });
  }

  trasferTask(event: CdkDragDrop<any>, state: number) {
    transferArrayItem(event.previousContainer.data,
      event.container.data,
      event.previousIndex,
      event.currentIndex);
    var task = event.container.data[event.currentIndex];
    task.state = state;
    this.updatedState.emit(task);
  }
  dropTodo(event: CdkDragDrop<any>) {
    
    this.trasferTask(event, 0);
  }

  dropInProgress(event: CdkDragDrop<any>) {
    
    this.trasferTask(event, 1);
  }

  dropDone(event: CdkDragDrop<any>) {
    
    this.trasferTask(event, 2);
  }

}
