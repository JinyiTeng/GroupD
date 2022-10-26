import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomepageComponent } from './components/homepage/homepage.component';
import { AddStaffComponent } from './components/staffs/add-staff/add-staff.component';
import { StaffsListComponent } from './components/staffs/staffs-list/staffs-list.component';
import { AddCustomerComponent } from './components/customers/add-customer/add-customer.component';
import { CustomersListComponent } from './components/customers/customers-list/customers-list.component';
import { PersonComponent } from './person/person.component';
import { EditStaffComponent } from './components/staffs/edit-staff/edit-staff.component';
const routes: Routes = [
  { path: 'person', component: PersonComponent },
  { path: '', component: HomepageComponent},
  { path: 'staffs', component: StaffsListComponent},
  { path: 'staffs/add', component: AddStaffComponent},
  {
    path: 'customers/add',
    component: AddCustomerComponent 
  },
  {
    path: 'customers',
    component: CustomersListComponent 
  },
  {
    path: 'staffs/edit/:staffId',
    component: EditStaffComponent 
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
