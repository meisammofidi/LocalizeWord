import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { AlertifyService } from '../_services/alertify.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  model: any = {};
  constructor(public authService: AuthService, private router: Router, private alertify: AlertifyService) { }

  ngOnInit() { }

  login() {
    this.authService.login(this.model).subscribe(
      next => {
        this.alertify.success('به سامانه خوش آمدید');
      },
      error => {
        this.alertify.error(error);
      },
      () => {
        this.router.navigate(['/home']);
      }
    );
  }
}
