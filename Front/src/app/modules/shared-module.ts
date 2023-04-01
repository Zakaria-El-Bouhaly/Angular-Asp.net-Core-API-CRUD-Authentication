import { CommonModule } from "@angular/common";
import { NgModule } from "@angular/core";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { ModalComponent } from "../components/modal/modal.component";

@NgModule({

    declarations: [
        ModalComponent
    ],

    imports: [
        FormsModule,
        CommonModule,       
        ReactiveFormsModule
    ]
    ,
    exports: [
        FormsModule,
        CommonModule,       
        ReactiveFormsModule,
        ModalComponent
    ]

})

export class SharedModule { }