import { Component, OnInit } from '@angular/core';
import { FACULTIES } from '../mocks/mocks.faculties';
import { Faculty } from '../models/faculty';


@Component({
  selector: 'app-faculties',
  templateUrl: './faculties.component.html',
  styleUrls: ['./faculties.component.css']
})
export class FacultiesComponent implements OnInit {

  faculties: Faculty [];

  constructor() { }

  ngOnInit() {
    this.faculties = FACULTIES;
  }

}
