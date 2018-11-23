import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { Router } from '@angular/router';
import { AlertifyService } from '../_services/alertify.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  model: any = {};

  constructor(private authService: AuthService, private route: Router, private alertify: AlertifyService) {}

  ngOnInit() {}

  register() {
    this.authService.register(this.model).subscribe(() => {
      this.alertify.success('نام نویسی در سامانه انجام شد');
    }, error => {
      this.alertify.error(error);
    }, () => {
      this.route.navigate(['/home']);
    }
    );
  }
  cancel() {
    console.log('Cancelled');
  }
}
