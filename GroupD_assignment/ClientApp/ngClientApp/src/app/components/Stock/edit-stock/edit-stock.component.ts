import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { Stock } from 'src/app/models/stock.model';
import { StockService } from 'src/app/services/stock.service';
import { FormBuilder, FormGroup, Validators, FormControl } from '@angular/forms';
import { AmountValidator } from '../validators/amount.validator';
import { PriceValidator } from '../validators/price.validator';

@Component({
  selector: 'app-edit-stock',
  templateUrl: './edit-stock.component.html',
  styleUrls: ['./edit-stock.component.less']
})
export class EditStockComponent implements OnInit, OnDestroy {
  editStockRequest: Stock = {
    stockID: 0,
    productName: '',
    orderAmount: 0,
    totalOrderPrice: 0
  };

  detailsForm = new FormGroup({
    stockID: new FormControl(0),
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

  sub: Subscription | undefined;

  constructor(private route: ActivatedRoute,
    private router: Router,
    private stockService: StockService,
    private fb: FormBuilder) { }

  ngOnInit(): void {
    this.sub = this.route.queryParams.subscribe(params => {
      console.log(params);
      const id = + params['id']; // (+) converts string 'id' to a number
      this.stockService.getStock(id).subscribe(stock => {
        if (stock) {
          this.editStockRequest = stock;
          this.detailsForm.setValue({
            stockID: stock.stockID,
            productName: stock.productName,
            orderAmount: stock.orderAmount,
            totalOrderPrice: stock.totalOrderPrice
          });
        }
      });
    });
    this.detailsForm = this.fb.group({
      stockID: new FormControl(0),
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

  ngOnDestroy(): void {
    if (this.sub) {
      this.sub.unsubscribe();
    }
  }

  delete(){
    this.stockService.delete(this.editStockRequest.stockID)
      .subscribe({
        next: (stock) => {
          this.router.navigate(['stock']);
          console.log(stock);
        }
      });
  }

  edit(value: any) {
    this.stockService.edit({
      stockID: value.stockID,
      productName: value.productName,
      totalOrderPrice: value.totalOrderPrice,
      orderAmount: value.lossAmount
    })
      .subscribe({
        next: (stock) => {
          this.router.navigate(['stock']);
          console.log(stock);
        }
      });
  }
}
