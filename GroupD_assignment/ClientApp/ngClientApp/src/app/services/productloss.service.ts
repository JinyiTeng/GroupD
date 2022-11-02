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

  getAllProductLosss(): Observable<ProductLoss[]> {
    return this.http.get<ProductLoss[]>(this.baseApiUrl + '/api/ProductLoss');
  }

  addProductLoss(addProductLossRequest: ProductLoss): Observable<ProductLoss> {
    return this.http.post<ProductLoss>(this.baseApiUrl + '/api/ProductLoss',addProductLossRequest);
  }

  getProductLoss(productLossID: string): Observable<ProductLoss> {
    return this.http.get<ProductLoss>(this.baseApiUrl + '/api/ProductLoss/' + productLossID)
  }

  updateProductLoss(productLossID: number, updateRequest: ProductLoss): Observable<ProductLoss> {
    return this.http.put<ProductLoss>(this.baseApiUrl + '/api/ProductLoss/' + productLossID, updateRequest);

  }

  delete(id: number){
    return this.http.delete(this.baseApiUrl + '/api/ProductLoss/' + id);
  }
}
