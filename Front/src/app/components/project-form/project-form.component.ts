import { Component, EventEmitter, Input, Output, SimpleChanges } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { FullProject, Project } from 'src/app/models/Project';

@Component({
  selector: 'app-project-form',
  templateUrl: './project-form.component.html',
  styleUrls: ['./project-form.component.scss']
})
export class ProjectFormComponent {

  myForm!: FormGroup;
  @Output() submitForm = new EventEmitter();
  @Input() formProject: any;

  constructor() { }

  ngOnInit(): void {
    this.myForm = new FormGroup({
      id: new FormControl(0),
      title: new FormControl("", [Validators.required, Validators.minLength(3)]),
      description: new FormControl("", [Validators.required, Validators.minLength(3)]),
    });

    if (this.formProject) {
      this.setFormValue(this.formProject);
    }
  }

  ngOnChanges(changes: SimpleChanges) {
    if (changes['formProject'] && this.myForm) {
      this.setFormValue(this.formProject);
    }
  }

  setFormValue(project: any) {
    this.myForm.setValue({
      id: this.formProject.id,
      title: this.formProject.title,
      description: this.formProject.description,
    }
    );
  }
  onSubmit() {
    this.submitForm.emit(this.myForm.value);
  }
}
