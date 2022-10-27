import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Stock } from 'src/app/models/stock.model';
import { StockService } from 'src/app/services/stock.service';
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

  constructor(
    private router: Router,
    private stockService: StockService) { }

  ngOnInit(): void {
  }

  save() {
    this.stockService.save(this.addStockRequest)
      .subscribe({
        next: (stock: any) => {
          this.router.navigate(['stocks']);
          console.log(stock);
        }
      });
  }
}
