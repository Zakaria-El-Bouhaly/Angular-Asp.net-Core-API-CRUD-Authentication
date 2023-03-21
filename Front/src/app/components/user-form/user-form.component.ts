import { Component, EventEmitter, Input, Output, SimpleChanges } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-user-form',
  templateUrl: './user-form.component.html',
  styleUrls: ['./user-form.component.scss']
})
export class UserFormComponent {


  myForm!: FormGroup;
  @Output() submitForm = new EventEmitter();
  @Input() formUserProject: any;

  constructor() { }

  ngOnInit(): void {
    this.myForm = new FormGroup({
      userId: new FormControl(this.formUserProject.userId),
      projectId: new FormControl(this.formUserProject.projectId),
      isOwner: new FormControl(this.formUserProject.isOwner, Validators.required)
    });
  }

  ngOnChanges(changes: SimpleChanges) {
    if (changes['formUserProject'] && this.myForm) {
      this.myForm.setValue({
        userId: this.formUserProject.userId,
        projectId: this.formUserProject.projectId,
        isOwner: this.formUserProject.isOwner
      }
      );
    }
  }

  onSubmit() {
    this.submitForm.emit(this.myForm.value);
  }
}
