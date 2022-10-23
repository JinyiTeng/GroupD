import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { PersonComponent } from './person/person.component';
import { StaffsListComponent } from './components/staffs/staffs-list/staffs-list.component';
import { AddStaffComponent } from './components/staffs/add-staff/add-staff.component';

@NgModule({
  declarations: [
    AppComponent,
    PersonComponent,
    StaffsListComponent,
    AddStaffComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
