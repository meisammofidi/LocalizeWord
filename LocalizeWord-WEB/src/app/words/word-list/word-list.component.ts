import { Component, OnInit, Input } from '@angular/core';
import { WordService } from '../../_services/Word.service';
import { AlertifyService } from '../../_services/alertify.service';
import { Word } from '../../_models/Word';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-word-list',
  templateUrl: './word-list.component.html',
  styleUrls: ['./word-list.component.css']
})
export class WordListComponent implements OnInit {
  @Input() words: Word[];

  constructor(
    private wordService: WordService,
    private alertify: AlertifyService,
    private route: ActivatedRoute
  ) {}

  ngOnInit() {
    this.route.data.subscribe(data => {
      this.words = data['words'];
    });
  }

  // loadWords() {
  //   this.wordService.getWords().subscribe(
  //     (words: Word[]) => {
  //       this.words = words;
  //     },
  //     error => {
  //       this.alertify.error(error);
  //     }
  //   );
  // }

  isEmptyArray(arr) {
    return arr && Object.keys(arr).length === 0;
  }

  findWords() {
    this.wordService.findWords(this.route.snapshot.params['term']).subscribe(
      (words: Word[]) => {
        this.words = words;
      },
      error => {
        this.alertify.error(error);
      }
    );
    //  this.alertify.message('Your typed =' + inputText);
  }
}
