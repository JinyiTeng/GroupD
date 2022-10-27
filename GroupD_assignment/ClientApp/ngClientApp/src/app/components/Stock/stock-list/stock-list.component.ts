import { Component, OnInit } from '@angular/core';
import { Stock } from 'src/app/models/stock.model';
import { StockService } from 'src/app/services/stock.service';

@Component({
  selector: 'app-stock-list',
  templateUrl: './stock-list.component.html',
  styleUrls: ['./stock-list.component.less']
})
export class StockListComponent implements OnInit {

  stocks: Stock[] = [];
  constructor(private stockService: StockService) { }

  ngOnInit(): void {
    this.stockService.getAllStocks()
    .subscribe({
      next: (stocks) => {
        this.stocks = stocks;
        console.log(stocks);
      },
      error: (response) => {
        console.log(response);
      }
    }

    )
    

  }

}
