import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ProductLoss } from 'src/app/models/ProductLoss.model';
import { Stock } from 'src/app/models/stock.model';
import { ProductLossService } from 'src/app/services/productloss.service';
import { StockService } from 'src/app/services/stock.service';

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

  constructor(
    private router: Router,
    private productlossService: ProductLossService) { }

  ngOnInit(): void {
  }

  addProductLoss() {
    this.productlossService.addProductLoss(this.addProductLossRequest)
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

