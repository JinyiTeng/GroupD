import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { ProductLoss } from '../models/ProductLoss.model';

@Injectable({
  providedIn: 'root'
})
export class ProductLossService {

  baseApiUrl: string = environment.baseApiUrl;

  constructor(private http: HttpClient) { }

  getProductLoss(id: number): Observable<ProductLoss> {
    return this.http.get<ProductLoss>(this.baseApiUrl + '/api/ProductLoss/' + id);
  }

  getAllProductLosss(): Observable<ProductLoss[]> {
    return this.http.get<ProductLoss[]>(this.baseApiUrl + '/api/ProductLoss');
  }

  save(productLoss: ProductLoss) {
    return this.http.post(this.baseApiUrl + '/api/ProductLoss', productLoss);
  }

  edit(productLoss: ProductLoss){
    return this.http.put(this.baseApiUrl + '/api/ProductLoss/update', productLoss);
  }

  delete(id: number){
    return this.http.delete(this.baseApiUrl + '/api/ProductLoss/' + id);
  }
}
