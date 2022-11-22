import { Component, OnInit } from '@angular/core';
import { faSearch, faRefresh, faBook} from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-bookspace',
  templateUrl: './bookspace.component.html',
  styleUrls: ['./bookspace.component.scss']
})
export class BookspaceComponent implements OnInit {

  faSearch = faSearch;
  faRefresh = faRefresh;
  faBook = faBook;


  constructor() { }

  ngOnInit(): void {
  }

}
