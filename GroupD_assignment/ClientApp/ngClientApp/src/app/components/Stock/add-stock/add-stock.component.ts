import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Stock } from 'src/app/models/stock.model';
import { StockService } from 'src/app/services/stock.service';
import { FormBuilder, FormGroup, Validators, FormControl } from '@angular/forms';
import { AmountValidator } from '../validators/amount.validator';
import { PriceValidator } from '../validators/price.validator';

@Component({
  selector: 'app-add-stock',
  templateUrl: './add-stock.component.html',
  styleUrls: ['./add-stock.component.less']
})
export class AddStockComponent implements OnInit {
  addStockRequest: Stock = {
    stockID: 0,
    productName: '',
    orderAmount: 0,
    totalOrderPrice: 0
  };

  detailsForm = new FormGroup({
    productName: new FormControl(''),
    totalOrderPrice: new FormControl(0),
    orderAmount: new FormControl(0)
  });

  validation_messages = {
    'productName': [
      { type: 'required', message: 'Product name is required' },
      { type: 'maxlength', message: 'Product name cannot be more than 100 characters long' }
    ],
    'orderAmount': [
      { type: 'required', message: 'Order Amount is required' },
      { type: 'maxlength', message: 'Order Amount cannot be more than 10 characters long' },
      { type: 'validAmount', message: 'Order Amount must be an integer' }
    ],
    'totalOrderPrice': [
      { type: 'required', message: 'Total Order Price is required' },
      { type: 'maxlength', message: 'Total Order Price cannot be more than 10 characters long' },
      { type: 'validPrice', message: 'Total Order Price A maximum of two decimal places are reserved' }
    ]
  }

  constructor(
    private router: Router,
    private stockService: StockService,
    private fb: FormBuilder) { }

  ngOnInit(): void {
    this.detailsForm = this.fb.group({
      productName: new FormControl('', Validators.compose([
       Validators.maxLength(100),
       Validators.required
      ])),
      orderAmount: new FormControl(0, Validators.compose([
        AmountValidator.validAmount,
        Validators.maxLength(10),
        Validators.required
       ])),
      totalOrderPrice: new FormControl(0, Validators.compose([
        PriceValidator.validPrice,
        Validators.maxLength(10),
        Validators.required
      ]))
    })
  }

  save(value: any) {
    this.stockService.save({
      stockID: 0,
      productName: value.productName,
      totalOrderPrice: value.totalOrderPrice,
      orderAmount: value.lossAmount
    })
      .subscribe({
        next: (stock: any) => {
          this.router.navigate(['stock']);
          console.log(stock);
        }
      });
  }
}
