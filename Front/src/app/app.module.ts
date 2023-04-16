import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { HeaderComponent } from './components/header/header.component';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { HttpInterceptorService } from './Services/http-interceptor.service';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToggleBtnComponent } from './components/toggle-btn/toggle-btn.component';
import { AppRoutingModule } from './modules/routing-module';
import { AuthModule } from './modules/auth-module';
import { SharedModule } from './modules/shared-module';
import { ProjectModule } from './modules/project-module';
import { AdminModule } from './modules/admin-module';
import { ProfileModule } from './modules/profile-module';








@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    ToggleBtnComponent
  ],
  imports: [
    HttpClientModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    AuthModule,
    SharedModule,
    ProjectModule,
    AdminModule,
    ProfileModule
  ],
  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: HttpInterceptorService,
      multi: true

    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
