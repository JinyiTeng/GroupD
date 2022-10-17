import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/app/models/Employee.model';
import { EmployeeService } from 'src/app/services/employee.service';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css']
})
export class EmployeeListComponent implements OnInit {

  Employee: Employee[] = [];

  constructor(private employeeservice: EmployeeService) { }

  ngOnInit(): void {
    this.employeeservice.GetAllEmployee()
    .subscribe({
      next: (Employee) => {
        console.log(Employee);
        this.Employee = Employee;
      },
      error: (Response) => {
        console.log(Response);
      }
      
    });

  }

}
