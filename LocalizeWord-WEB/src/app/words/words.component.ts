import { AlertifyService } from './../_services/alertify.service';
import { Word } from './../_models/Word';
import { Component, OnInit } from '@angular/core';
import { WordService } from '../_services/Word.service';

@Component({
  selector: 'app-words',
  templateUrl: './words.component.html',
  styleUrls: ['./words.component.css']
})
export class WordsComponent implements OnInit {
  words: Word[];

  constructor(
    private wordService: WordService,
    private alertify: AlertifyService
  ) {}

  ngOnInit() {
    this.loadWords();
  }

  loadWords() {
    this.wordService.getWords().subscribe(
      (words: Word[]) => {
        this.words = words;
      },
      error => {
        this.alertify.error(error);
      }
    );
  }

  isEmptyArray(arr) {
    return (arr && (Object.keys(arr).length === 0));
  }
}
