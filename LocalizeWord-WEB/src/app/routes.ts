import { WordDetailComponent } from './words/word-detail/word-detail.component';
import { WordListComponent } from './words/word-list/word-list.component';
import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';
import { LoginComponent } from './login/login.component';
import { MembersComponent } from './members/members.component';
import { HomeLayoutComponent } from './layouts/home-layout.component';
import { SignupLayoutComponent } from './layouts/signup-layout.component';
import { AuthGuard } from './_guards/auth.guard';
import { WordListResolver } from './_resolvers/word-list.resolver';

export const appRoutes: Routes = [
  {
    path: '',
    component: HomeLayoutComponent,
    children: [
      { path: '', component: HomeComponent },
      { path: 'members', component: MembersComponent, canActivate: [AuthGuard] },
      { path: 'words', component: WordListComponent, canActivate: [AuthGuard] },
      { path: 'words/:id', component: WordDetailComponent, canActivate: [AuthGuard] },
      { path: 'words/find/:term', component: WordListComponent, resolve: {words: WordListResolver},  canActivate: [AuthGuard] }
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
