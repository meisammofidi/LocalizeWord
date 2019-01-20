import { Component, OnInit } from '@angular/core';
import { WordService } from '../../_services/Word.service';
import { AlertifyService } from '../../_services/alertify.service';
import { Word } from '../../_models/Word';

@Component({
  selector: 'app-word-list',
  templateUrl: './word-list.component.html',
  styleUrls: ['./word-list.component.css']
})
export class WordListComponent implements OnInit {

  words: Word[];

  constructor(
    private wordService: WordService,
    private alertify: AlertifyService) { }

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
