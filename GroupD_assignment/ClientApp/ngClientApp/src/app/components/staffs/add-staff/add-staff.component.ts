import { Component, OnInit } from '@angular/core';
import { Route, Router } from '@angular/router';
import { Staff } from 'src/app/models/staff.model';
import { StaffsService } from 'src/app/services/staffs.service';

@Component({
  selector: 'app-add-staff',
  templateUrl: './add-staff.component.html',
  styleUrls: ['./add-staff.component.less']
})
export class AddStaffComponent implements OnInit {

  addStaffRequest: Staff = {
    staffId: 0,
    staffName: '',
    staffPhone: '',
    staffPosition: '',
    staffShift: ''
  };

  constructor(private staffService: StaffsService, private router: Router) { }

  ngOnInit(): void {
  }

  addStaff() {
    this.staffService.addStaff(this.addStaffRequest)
    .subscribe({
      next: (staff) => {
        this.router.navigate(['staffs']);
        console.log(staff);
      }
    });

  }

}
