/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { WordService } from './Word.service';

describe('Service: Word', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [WordService]
    });
  });

  it('should ...', inject([WordService], (service: WordService) => {
    expect(service).toBeTruthy();
  }));
});
