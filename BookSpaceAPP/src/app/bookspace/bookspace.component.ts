import { Component, OnInit } from '@angular/core';
import { fas } from '@fortawesome/free-solid-svg-icons';
import { far } from '@fortawesome/free-regular-svg-icons';
import { FontAwesomeModule, FaIconLibrary } from '@fortawesome/angular-fontawesome';


import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';



@Component({
  selector: 'app-bookspace',
  templateUrl: './bookspace.component.html',
  styleUrls: ['./bookspace.component.scss']
})
export class BookspaceComponent implements OnInit {


  constructor(library: FaIconLibrary) {
    library.addIconPacks(fas, far);
    }

  ngOnInit(): void {
  }

}
