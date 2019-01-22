import { catchError } from 'rxjs/operators';
import { Observable, of } from 'rxjs';
import { Injectable } from '@angular/core';
import { Resolve, Router, ActivatedRouteSnapshot } from '@angular/router';
import { WordService } from '../_services/Word.service';
import { Word } from '../_models/Word';
import { AlertifyService } from 'src/app/_services/alertify.service';

@Injectable()
export class WordListResolver implements Resolve<Word[]> {
  constructor(
    private wordService: WordService,
    private alertify: AlertifyService,
    private router: Router
  ) {}

  // Resolver is going to load data first befor load the component
  resolve(route: ActivatedRouteSnapshot): Observable<Word[]> {
    return this.wordService.findWords(route.params['term']).pipe(
      catchError(error => {
        this.alertify.error('Problem retrieving data');
        this.router.navigate(['/home']);
        return of(null);
      })
    );
  }
}
