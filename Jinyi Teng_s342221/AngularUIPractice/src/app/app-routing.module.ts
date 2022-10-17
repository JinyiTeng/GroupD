import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddEmployeeComponent } from './componenets/Employee/add-employee/add-employee.component';
import { EmployeeListComponent } from './componenets/Employee/employee-list/employee-list.component';

const routes: Routes = [
  {
    path: '',
    component: EmployeeListComponent
  },
  {
     path: 'Employee',
     component: EmployeeListComponent
  },
  {
    path: 'Employee/add',
    component: AddEmployeeComponent
 }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
