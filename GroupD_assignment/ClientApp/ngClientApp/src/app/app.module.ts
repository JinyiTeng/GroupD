import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { PersonComponent } from './person/person.component';
import { StaffsListComponent } from './components/staffs/staffs-list/staffs-list.component';
import { AddStaffComponent } from './components/staffs/add-staff/add-staff.component';
import { AddCustomerComponent } from './components/customers/add-customer/add-customer.component';
import { CustomersListComponent } from './components/customers/customers-list/customers-list.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HomepageComponent } from './components/homepage/homepage.component';
import { EditStaffComponent } from './components/staffs/edit-staff/edit-staff.component';
import { AddProductLossComponent } from './components/ProductLoss/add-product-loss/add-product-loss.component';
import { AddStockComponent } from './components/Stock/add-stock/add-stock.component';
import { EditProductLossComponent } from './components/ProductLoss/edit-productloss/edit-productloss.component';
import { EditStockComponent } from './components/Stock/edit-stock/edit-stock.component';
import { ProductLossListComponent } from './components/ProductLoss/product-loss-list/product-loss-list.component';
import { StockListComponent } from './components/Stock/stock-list/stock-list.component';

@NgModule({
  declarations: [
    AppComponent,
    PersonComponent,
    StaffsListComponent,
    AddStaffComponent,
    AddCustomerComponent,
    CustomersListComponent,
    HomepageComponent,
    EditStaffComponent,
    StockListComponent,
    AddStockComponent,
    ProductLossListComponent,
    AddProductLossComponent,
    EditStockComponent,
    EditProductLossComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
