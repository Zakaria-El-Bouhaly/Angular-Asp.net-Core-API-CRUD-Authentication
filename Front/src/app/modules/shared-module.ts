import { CommonModule } from "@angular/common";
import { NgModule } from "@angular/core";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { ModalComponent } from "../components/sharedComponents/modal/modal.component";
import { DragDropModule } from '@angular/cdk/drag-drop';
import { FormContainerComponent } from "../components/sharedComponents/form-container/form-container.component";
import { ConfirmationDialogComponent } from "../components/sharedComponents/confirmation-dialog/confirmation-dialog.component";
import { ProjectFormComponent } from "../components/sharedComponents/project-form/project-form.component";
import { TableContainerComponent } from "../components/sharedComponents/table-container/table-container.component";
import { TableModule } from 'primeng/table';
import { ButtonModule } from "primeng/button";
import { DropdownModule } from 'primeng/dropdown';
import { InputTextModule } from 'primeng/inputtext';


@NgModule({
    declarations: [
        ModalComponent,
        FormContainerComponent,              
        ConfirmationDialogComponent,
        ProjectFormComponent,        
        TableContainerComponent
    ],

    imports: [
        FormsModule,
        CommonModule,
        ReactiveFormsModule,
        DragDropModule,
        TableModule,
        ButtonModule,
        DropdownModule,
        InputTextModule
    ]
    ,
    exports: [
        FormsModule,
        CommonModule,
        ReactiveFormsModule,
        ModalComponent,
        DragDropModule,
        FormContainerComponent,              
        ConfirmationDialogComponent,
        ProjectFormComponent,        
        TableContainerComponent ,
        TableModule ,
        ButtonModule   ,
        DropdownModule,
        InputTextModule
    ]

})

export class SharedModule { }