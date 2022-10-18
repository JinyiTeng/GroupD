import { Component, OnInit } from '@angular/core';
import { Employee } from '../models/employee.model';
@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.less']
})
export class EmployeesComponent implements OnInit {

  employees: Employee[] = [
    {
      id: '4r5t6y7u8i',
      name: 'John',
      email: 'jhon@gmail.com',
      phone: '345675443',
      salary: '4000',
      department: 'human resource'
    },
    {
      id: '4rttt6y7u8i',
      name: 'Jim',
      email: 'jim@gmail.com',
      phone: '7868898',
      salary: '7000',
      department: 'information technology'
    },
    {
      id: '4r5t6y7u8i',
      name: 'Tim',
      email: 'Tim@gmail.com',
      phone: '786558',
      salary: '9000',
      department: 'accounts'
    }
  ];
  constructor() { }

  ngOnInit(): void {
     this.employees.push()

  }

}
