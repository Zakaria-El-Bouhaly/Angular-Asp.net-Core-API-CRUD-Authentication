import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProfileFormComponent } from '../components/profileComponents/profile-form/profile-form.component';
import { ProfileComponent } from '../components/profileComponents/profile/profile.component';

import { AuthGuard } from '../helpers/AuthGuard';
import { SharedModule } from './shared-module';

const routes: Routes = [
    { path: '', component: ProfileComponent, canActivate: [AuthGuard] },
]


@NgModule({
    declarations: [
        ProfileComponent,
        ProfileFormComponent
    ],
    imports: [
        SharedModule,
        RouterModule.forChild(routes)
    ],
    exports: [

    ],
    providers: [
    ]
})

export class ProfileModule { }