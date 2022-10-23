import { Component, OnInit } from '@angular/core';
import { Staff } from 'src/app/models/staff.model';
import { StaffsService } from 'src/app/services/staffs.service';

@Component({
  selector: 'app-staffs-list',
  templateUrl: './staffs-list.component.html',
  styleUrls: ['./staffs-list.component.less']
})
export class StaffsListComponent implements OnInit {

  staffs: Staff[] = [];
  constructor(private staffsService: StaffsService) { }

  ngOnInit(): void {
    this.staffsService.getAllStaffs()
    .subscribe({
      next: (staffs) => {
        this.staffs = staffs;
        console.log(staffs);
      },
      error: (response) => {
        console.log(response);
      }
    }

    )
    

  }

}
