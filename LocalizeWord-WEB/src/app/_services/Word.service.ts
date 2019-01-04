import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { Word } from '../_models/Word';


@Injectable({
  providedIn: 'root'
})
export class WordService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) {}

  getWords(): Observable<Word[]> {
    return this.http.get<Word[]>(this.baseUrl + 'words');
  }

  getWord(id): Observable<Word> {
    return this.http.get<Word>(this.baseUrl + 'words/' + id);
  }
}
