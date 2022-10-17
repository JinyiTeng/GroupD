import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { EmitOutput } from 'typescript';
import { Employee } from '../models/Employee.model';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  baseApiUrl: string = environment.baseApiUrl;

  constructor(private http: HttpClient) { }

  GetAllEmployee(): Observable<Employee[]> {
   return this.http.get<Employee[]>(this.baseApiUrl + '/api/Employee');
  }

  addEmployee(addEmployeeRequest: Employee): Observable<Employee> {
    addEmployeeRequest.Employeeid = '0';
    return this.http.post<Employee>(this.baseApiUrl + '/api/Employee', addEmployeeRequest);
  }
}