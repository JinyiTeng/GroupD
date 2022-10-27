import { Component, OnDestroy, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { Stock } from 'src/app/models/stock.model';
import { StockService } from 'src/app/services/stock.service';

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

  sub: Subscription | undefined;

  constructor(private route: ActivatedRoute,
    private router: Router,
    private stockService: StockService) { }

  ngOnInit(): void {
    this.sub = this.route.queryParams.subscribe(params => {
      console.log(params);
      const id = + params['id']; // (+) converts string 'id' to a number
      this.stockService.getStock(id).subscribe(stock => {
        if (stock) {
          this.editStockRequest = stock;
        }
      });
    });
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
          this.router.navigate(['stocks']);
          console.log(stock);
        }
      });
  }

  edit() {
    this.stockService.edit(this.editStockRequest)
      .subscribe({
        next: (stock) => {
          this.router.navigate(['stocks']);
          console.log(stock);
        }
      });
  }
}
