import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ProductLoss } from 'src/app/models/ProductLoss.model';
import { ProductLossService } from 'src/app/services/productloss.service';
import { FormBuilder, FormGroup, Validators, FormControl } from '@angular/forms';
import { AmountValidator } from '../validators/amount.validator';

@Component({
  selector: 'app-add-productLoss',
  templateUrl: './add-product-Loss.component.html',
  styleUrls: ['./add-product-Loss.component.less']
})
export class AddProductLossComponent implements OnInit {
  addProductLossRequest: ProductLoss = {
    productLossID: 0,
    productName: '',
    reason: '',
    lossAmount: 0
  };

  detailsForm = new FormGroup({
    productName: new FormControl(''),
    reason: new FormControl(''),
    lossAmount: new FormControl('')
  }); 

  validation_messages = {
    'productName': [
      { type: 'required', message: 'Product name is required' },
      { type: 'maxlength', message: 'Product name cannot be more than 100 characters long' }
    ],
    'reason': [
      { type: 'required', message: 'Reason is required' },
      { type: 'maxlength', message: 'Reason cannot be more than 500 characters long' }
    ],
    'lossAmount': [
      { type: 'required', message: 'Loss Amount is required' },
      { type: 'maxlength', message: 'Loss Amount cannot be more than 10 characters long' },
      { type: 'validAmount', message: 'Loss Amount must be an integer' }
    ]
  }

  constructor(
    private router: Router,
    private productlossService: ProductLossService,
    private fb: FormBuilder) { }

  ngOnInit() {
    this.detailsForm = this.fb.group({
      productName: new FormControl('', Validators.compose([
       Validators.maxLength(100),
       Validators.required
      ])),
      reason: new FormControl('', Validators.compose([
        Validators.maxLength(500),
        Validators.required
       ])),
      lossAmount: new FormControl('', Validators.compose([
        AmountValidator.validAmount,
        Validators.maxLength(10),
        Validators.required
       ]))
    })
  }

  addProductLoss(value: any){
    console.log(value);
    this.productlossService.addProductLoss({
      productLossID: 0,
      productName: value.productName,
      reason: value.reason,
      lossAmount: value.lossAmount
    })
      .subscribe({
        next: (productLoss) => {
          this.router.navigate(['productLosss']);
          console.log(productLoss);
        }
      })
  }
}
function productLoss(productLoss: any) {
  throw new Error('Function not implemented.');
}

