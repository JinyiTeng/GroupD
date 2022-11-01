import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Staff } from 'src/app/models/staff.model';
import { StaffsService } from 'src/app/services/staffs.service';

@Component({
  selector: 'app-edit-staff',
  templateUrl: './edit-staff.component.html',
  styleUrls: ['./edit-staff.component.less']
})
export class EditStaffComponent implements OnInit {

  staffDetails: Staff = {
    staffId: 0,
    staffName: '',
    staffPhone: '',
    staffPosition: '',
    staffShift: ''
  }

  constructor(private route: ActivatedRoute, private staffService: StaffsService, private router: Router) { }

  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next: (params) => {
        const staffId = params.get('staffId');

        if (staffId) {
          this.staffService.getStaff(staffId)
          .subscribe({
            next: (response) => {
              this.staffDetails = response;

            }

          })
        }
      }
    })
  }

  updateStaff() {
    this.staffService.updateStaff(this.staffDetails.staffId, this.staffDetails)
    .subscribe({
      next: (response) => {
        this.router.navigate(['staffs'])
      }
    })


  }

  deleteStaff(staffId: number) {
    this.staffService.deleteStaff(staffId)
    .subscribe({
      next: (response) => {
        this.router.navigate(['staffs']);
      }
    });
  }
}
