import { ErrorInterceptorProvider } from './_services/error.interceptor';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {HttpClientModule} from '@angular/common/http';
import {FormsModule} from '@angular/forms';
import { BsDropdownModule } from 'ngx-bootstrap';
import { RouterModule } from '@angular/router';
import { AuthGuard } from './_guards/auth.guard';
import { JwtModule } from '@auth0/angular-jwt';

import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { AuthService } from './_services/auth.service';
import { WordService } from './_services/Word.service';
import { SearchComponent } from './search/search.component';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';
import { AlertifyService } from './_services/alertify.service';
import { MembersComponent } from './members/members.component';
import { LoginComponent } from './login/login.component';
import { SignupLayoutComponent } from './layouts/signup-layout.component';
import { HomeLayoutComponent } from './layouts/home-layout.component';
import { WordListComponent } from './words/word-list/word-list.component';
import { WordCardComponent } from './words/word-card/word-card.component';
import { appRoutes } from './routes';
import { WordDetailComponent } from './words/word-detail/word-detail.component';
import { WordListResolver } from './_resolvers/word-list.resolver';

export function tokenGetter() {
   return localStorage.getItem('token');
}

@NgModule({
   declarations: [
      AppComponent,
      NavComponent,
      SearchComponent,
      HomeComponent,
      RegisterComponent,
      MembersComponent,
      LoginComponent,
      HomeLayoutComponent,
      SignupLayoutComponent,
      WordListComponent,
      WordCardComponent,
      WordDetailComponent
   ],
   imports: [
      BrowserModule,
      HttpClientModule,
      FormsModule,
      BsDropdownModule.forRoot(),
      RouterModule.forRoot(appRoutes),
      JwtModule.forRoot({
         config: {
            tokenGetter: tokenGetter,
            whitelistedDomains: ['localhost:5000'],
            blacklistedRoutes: ['localhost:5000/api/auth']
         }
      })
   ],
   providers: [
      AuthService,
      ErrorInterceptorProvider,
      AlertifyService,
      AuthGuard,
      WordService,
      WordListResolver
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
