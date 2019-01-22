import { Component, OnInit, Input } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {
  inputText: string;

  constructor(private router: Router) {}
  ngOnInit() {}

  search() {
    if (this.inputText) {
      this.router.navigate(['/words/find/', this.inputText]); // Connect to WordListComponent which is clarified in routes.ts
    } else {
      this.router.navigate(['/home']);
    }
  }
}
