import { Component, OnInit } from '@angular/core';
import { CalendarServiceService } from '../../services/calendar-service.service';
import { Observable } from 'rxjs';
 
@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent implements OnInit {
  users$: Object;

  constructor(private data: CalendarServiceService) { }

  ngOnInit() {
    this.data.getUsers().subscribe(
      data => this.users$ = data
    )
  }

}
