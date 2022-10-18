import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EmployeesComponent } from './employees/employees.component';
import { PersonComponent } from './person/person.component';
const routes: Routes = [
  { path: 'person', 
  component: PersonComponent 
},

{ path: 'employees', 
component: EmployeesComponent 
},



];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
