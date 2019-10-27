import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-job',
  templateUrl: './job.component.html',
  styleUrls: ['./job.component.css']
})
export class JobComponent implements OnInit {

  

  columnDefs = [
    { headerName: 'ID', field: 'id', sortable: true, filter: true },
    { headerName: 'Name', field: 'name', sortable: true, filter: true },
    { headerName: 'Description', field: 'description', sortable: true, filter: true },
    { headerName: 'Create Date', field: 'createDate', sortable: true, filter: true },
    { headerName: 'Created User', field: 'createdUser', sortable: true, filter: true },
  ];

  //rowData = [
  //  { make: 'Toyota', model: 'Celica', price: 35000 },
  //  { make: 'Ford', model: 'Mondeo', price: 32000 },
  //  { make: 'Porsche', model: 'Boxter', price: 72000 }
  //];

  rowData: any;

  constructor(private http: HttpClient) {

  }

  ngOnInit() {
   // this.rowData = this.http.get('https://api.myjson.com/bins/15psn9');
    this.rowData = this.http.get('http://localhost:63644/api/job/GetJobs');


  }


}
