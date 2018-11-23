import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home-layout',
  template: `
  <div class="cbg-blueMid">
    <app-nav></app-nav>
    <app-search></app-search>
  </div>
  <router-outlet></router-outlet>
  `,
  styles: []
})
export class HomeLayoutComponent {

  constructor() { }
}
