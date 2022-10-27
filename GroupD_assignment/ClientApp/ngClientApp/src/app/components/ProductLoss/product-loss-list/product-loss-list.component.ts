import { Component, OnInit } from '@angular/core';
import { ProductLoss } from 'src/app/models/ProductLoss.model';
import { ProductLossService } from 'src/app/services/productloss.service';

@Component({
  selector: 'app-productLoss-list',
  templateUrl: './product-Loss-list.component.html',
  styleUrls: ['./product-Loss-list.component.less']
})
export class ProductLossListComponent implements OnInit {

  productLosss: ProductLoss[] = [];
  constructor(private productLossService: ProductLossService) { }

  ngOnInit(): void {
    this.productLossService.getAllProductLosss()
    .subscribe({
      next: (productLosss: ProductLoss[]) => {
        this.productLosss = productLosss;
        console.log(productLosss);
      },
      error: (response: any) => {
        console.log(response);
      }
    }

    )
    

  }

}
