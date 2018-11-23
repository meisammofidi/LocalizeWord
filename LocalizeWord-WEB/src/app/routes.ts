import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';
import { WordsComponent } from './words/words.component';
import { LoginComponent } from './login/login.component';
import { MembersComponent } from './members/members.component';
import { HomeLayoutComponent } from './layouts/home-layout.component';
import { SignupLayoutComponent } from './layouts/signup-layout.component';
import { AuthGuard } from './_guards/auth.guard';

export const appRoutes: Routes = [
  {
    path: '',
    component: HomeLayoutComponent,
    children: [
      { path: '', component: HomeComponent },
      { path: 'members', component: MembersComponent, canActivate: [AuthGuard] },
      { path: 'words', component: WordsComponent, canActivate: [AuthGuard] }
    ]
  },
  {
    path: '',
    component: SignupLayoutComponent,
    children: [
      { path: 'login', component: LoginComponent },
      { path: 'register', component: RegisterComponent }
    ]
  },
  { path: '**', redirectTo: '', pathMatch: 'full' }
];
