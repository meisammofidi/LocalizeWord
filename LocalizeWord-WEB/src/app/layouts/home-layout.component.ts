import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home-layout',
  template: `
    <app-nav></app-nav>
    <div class="cbg-blueMid">
    <app-search></app-search>
    </div>
    <router-outlet></router-outlet>
  `,
  styles: []
})
export class HomeLayoutComponent {
  constructor() {}
}
