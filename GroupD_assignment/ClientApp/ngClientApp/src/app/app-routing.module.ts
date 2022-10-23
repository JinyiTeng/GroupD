import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { StaffsListComponent } from './components/staffs/staffs-list/staffs-list.component';
import { PersonComponent } from './person/person.component';
const routes: Routes = [
  { path: 'person', component: PersonComponent },
  { path: '', component: StaffsListComponent},
  { path: 'staffs', component: StaffsListComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
