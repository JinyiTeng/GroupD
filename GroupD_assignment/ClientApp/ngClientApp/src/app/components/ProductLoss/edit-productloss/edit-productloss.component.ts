import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { ProductLoss } from 'src/app/models/ProductLoss.model';
import { ProductLossService } from 'src/app/services/productloss.service';
import { FormBuilder, FormGroup, Validators, FormControl } from '@angular/forms';
import { AmountValidator } from '../validators/amount.validator';

@Component({
  selector: 'app-edit-productLoss',
  templateUrl: './edit-productLoss.component.html',
  styleUrls: ['./edit-productLoss.component.less']
})
export class EditProductLossComponent implements OnInit {
  productLossDetails: ProductLoss = {
    productLossID: 0,
    productName: '',
    reason: '',
    lossAmount: 0
  };

  detailsForm = new FormGroup({
    productLossID: new FormControl(0),
    productName: new FormControl(''),
    reason: new FormControl(''),
    lossAmount: new FormControl(0)
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

  sub: Subscription | undefined;

  constructor(private route: ActivatedRoute, private productLossService: ProductLossService, private router: Router,
    private fb: FormBuilder) { }

  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next: (params) => {
        const productLossID = params.get('productLossID');

        if (productLossID) {
          this.productLossService.getProductLoss(productLossID)
          .subscribe({
            next: (response) => {
              this.productLossDetails = response;
              this.detailsForm.setValue({
                productLossID: response.productLossID,
                productName: response.productName,
                reason: response.reason,
                lossAmount: response.lossAmount
              });
            }

          })
        }
      }
    });

    this.detailsForm = this.fb.group({
      productLossID:new FormControl(0),
      productName: new FormControl('', Validators.compose([
       Validators.maxLength(100),
       Validators.required
      ])),
      reason: new FormControl('', Validators.compose([
        Validators.maxLength(500),
        Validators.required
       ])),
      lossAmount: new FormControl(0, Validators.compose([
        AmountValidator.validAmount,
        Validators.maxLength(10),
        Validators.required
       ]))
    });
  }

  updateProductLoss(value: any) {
    console.log(value);
    this.productLossService.updateProductLoss(value.productLossID, {
      productLossID: value.productLossID,
      productName: value.productName,
      reason: value.reason,
      lossAmount: value.lossAmount
    })
    .subscribe({
      next: (response) => {
        this.router.navigate(['productLosss'])
      }
    })
  }

  delete(){
    this.productLossService.delete(this.productLossDetails.productLossID)
      .subscribe({
        next: (productLoss) => {
          this.router.navigate(['productLosss']);
          console.log(productLoss);
        }
      });
  }
}
