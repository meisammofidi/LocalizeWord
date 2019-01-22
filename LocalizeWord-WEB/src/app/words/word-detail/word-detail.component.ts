import { Word } from './../../_models/Word';
import { Component, OnInit } from '@angular/core';
import { WordService } from 'src/app/_services/Word.service';
import { AlertifyService } from 'src/app/_services/alertify.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-word-detail',
  templateUrl: './word-detail.component.html',
  styleUrls: ['./word-detail.component.css']
})
export class WordDetailComponent implements OnInit {
  word: Word;
  constructor(
    private wordService: WordService,
    private alertify: AlertifyService,
    private route: ActivatedRoute
  ) {}

  ngOnInit() {
    this.loadWord();
  }

  loadWord() {
    this.wordService.getWord(+this.route.snapshot.params['id']).subscribe(
      (word: Word) => {
        this.word = word;
      },
      error => {
        this.alertify.error(error);
      }
    );
  }
}
