import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MembersListComponent } from './components/members/members-list/members-list.component';

const routes: Routes = [
  {
    path: '',
    component: MembersListComponent
  },
  {
    path: 'members',
    component: MembersListComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
