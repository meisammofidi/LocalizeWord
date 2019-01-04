import { Word } from './Word';
export interface Word {
  id: number;
  loanWordid?: number;
  context: string;
  languageid: number;
  languagekey: string;
  languagecaption: string;
  categoryid: number;
  categorykey: number;
  categorycaption: string;
  createdat: Date;
  updatedat: Date;
  isdeleted: boolean;
  nativewords: Word[];
}
