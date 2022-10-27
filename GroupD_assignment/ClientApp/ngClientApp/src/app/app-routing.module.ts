import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomepageComponent } from './components/homepage/homepage.component';
import { AddStaffComponent } from './components/staffs/add-staff/add-staff.component';
import { StaffsListComponent } from './components/staffs/staffs-list/staffs-list.component';
import { AddCustomerComponent } from './components/customers/add-customer/add-customer.component';
import { CustomersListComponent } from './components/customers/customers-list/customers-list.component';
import { PersonComponent } from './person/person.component';
import { EditStaffComponent } from './components/staffs/edit-staff/edit-staff.component';
import { StockListComponent } from './components/Stock/stock-list/stock-list.component';
import { AddStockComponent } from './components/Stock/add-stock/add-stock.component';
import { EditStockComponent } from './components/Stock/edit-stock/edit-stock.component';
import { ProductLossListComponent } from './components/ProductLoss/product-loss-list/product-loss-list.component';
import { AddProductLossComponent } from './components/ProductLoss/add-product-loss/add-product-loss.component';
import { EditProductLossComponent } from './components/ProductLoss/edit-productloss/edit-productloss.component';
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
  { path: 'stock', component: StockListComponent},
  { path: 'stock/add', component: AddStockComponent},
  { path: 'stock/edit', component: EditStockComponent},
  { path: 'productLosss', component: ProductLossListComponent},
  { path: 'productLosss/add', component: AddProductLossComponent},
  { path: 'productLosss/edit/:productLossID', component: EditProductLossComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
