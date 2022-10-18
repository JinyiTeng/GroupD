import { Component, OnInit } from '@angular/core';
import { Member } from 'src/app/models/member.model';

@Component({
  selector: 'app-members-list',
  templateUrl: './members-list.component.html',
  styleUrls: ['./members-list.component.css']
})
export class MembersListComponent implements OnInit {

  members: Member[] = [
    {
      id: '1',
    name: 'John Doe',
    email: 'john.doe@gmail.com',
    phone: 78764365,
    team: 'team A',
    position: 'Junior developer'  
    },
    {
      id: '2',
    name: 'Sameer Saini',
    email: 'sameer.saini@gmail.com',
    phone: 87609874,
    team: 'team A',
    position: 'Senior developer'  
    },
    {
      id: '3',
    name: 'Kyle Than',
    email: 'kyle.than@gmail.com',
    phone: 38643867,
    team: 'team A',
    position: 'Product manager'  
    },
    {
      id: '4',
    name: 'Lyn Vu',
    email: 'lyn.vu@gmail.com',
    phone: 67543890,
    team: 'team A',
    position: 'Tester'  
    }
  ];
  constructor() { }

  ngOnInit(): void {
      this.members

  }

}
