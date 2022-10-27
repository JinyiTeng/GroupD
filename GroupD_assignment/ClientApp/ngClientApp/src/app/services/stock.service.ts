import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Stock } from '../models/stock.model';

@Injectable({
  providedIn: 'root'
})
export class StockService {

  baseApiUrl: string = environment.baseApiUrl;

  constructor(private http: HttpClient) { }

  getStock(id: number): Observable<Stock> {
    return this.http.get<Stock>(this.baseApiUrl + '/api/Stock/' + id);
  }

  getAllStocks(): Observable<Stock[]> {
    return this.http.get<Stock[]>(this.baseApiUrl + '/api/Stock');
  }

  save(stock: Stock) {
    return this.http.post(this.baseApiUrl + '/api/Stock', stock);
  }

  edit(stock: Stock){
    return this.http.put(this.baseApiUrl + '/api/Stock/update', stock);
  }

  delete(id: number){
    return this.http.delete(this.baseApiUrl + '/api/Stock/' + id);
  }
}
