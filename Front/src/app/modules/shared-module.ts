import { CommonModule } from "@angular/common";
import { NgModule } from "@angular/core";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { ModalComponent } from "../components/modal/modal.component";
import { DragDropModule } from '@angular/cdk/drag-drop';
import { FormContainerComponent } from "../components/form-container/form-container.component";
import { MytableComponent } from "../components/mytable/mytable.component";
import { DateFormatPipe } from "../components/mytable/mydatePipe";
import { ConfirmationDialogComponent } from "../components/confirmation-dialog/confirmation-dialog.component";
import { ProjectFormComponent } from "../components/project-form/project-form.component";
import { DropdownSearchComponent } from "../components/dropdown-search/dropdown-search.component";
import { TableContainerComponent } from "../components/table-container/table-container.component";

@NgModule({
    declarations: [
        ModalComponent,
        FormContainerComponent,
        MytableComponent,
        DateFormatPipe,
        ConfirmationDialogComponent,
        ProjectFormComponent,
        DropdownSearchComponent,
        TableContainerComponent
    ],

    imports: [
        FormsModule,
        CommonModule,
        ReactiveFormsModule,
        DragDropModule
    ]
    ,
    exports: [
        FormsModule,
        CommonModule,
        ReactiveFormsModule,
        ModalComponent,
        DragDropModule,
        FormContainerComponent,
        MytableComponent,
        DateFormatPipe,
        ConfirmationDialogComponent,
        ProjectFormComponent,
        DropdownSearchComponent  ,
        TableContainerComponent     
    ]

})

export class SharedModule { }