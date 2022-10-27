import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { ProductLoss } from 'src/app/models/ProductLoss.model';
import { ProductLossService } from 'src/app/services/productloss.service';


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

  sub: Subscription | undefined;

  constructor(private route: ActivatedRoute, private productLossService: ProductLossService, private router: Router) { }

  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next: (params) => {
        const productLossID = params.get('productLossID');

        if (productLossID) {
          this.productLossService.getProductLoss(productLossID)
          .subscribe({
            next: (response) => {
              this.productLossDetails = response;

            }

          })
        }
      }
    })
  }

 
  updateProductLoss() {
    this.productLossService.updateProductLoss(this.productLossDetails.productLossID, this.productLossDetails)
    .subscribe({
      next: (response) => {
        this.router.navigate(['productLosss'])
      }
    })


  }
  
}
