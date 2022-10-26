import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Staff } from '../models/staff.model';

@Injectable({
  providedIn: 'root'
})
export class StaffsService {

  baseApiUrl: string = environment.baseApiUrl;

  constructor(private http: HttpClient) { }

  getAllStaffs(): Observable<Staff[]> {
    return this.http.get<Staff[]>(this.baseApiUrl + '/api/Staff');
  }

  addStaff(addStaffRequest: Staff): Observable<Staff> {
    return this.http.post<Staff>(this.baseApiUrl + '/api/Staff',addStaffRequest);
  }

  getStaff(staffId: string): Observable<Staff> {
    return this.http.get<Staff>(this.baseApiUrl + '/api/Staff/' + staffId)
  }

  updateStaff(staffId: number, updateStaffRequest: Staff): Observable<Staff> {
    return this.http.put<Staff>(this.baseApiUrl + '/api/Staff/' + staffId, updateStaffRequest);

  }
}
