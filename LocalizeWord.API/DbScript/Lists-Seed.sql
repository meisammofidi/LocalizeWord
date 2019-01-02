/* List seed */
-----------------------------------------------------------------------------
-----------------------------------------------------------------------------
INSERT into Lists (ListKey, Name, CreatedAt, UpdatedAt)
VALUES 
('language', 'Language', datetime(), datetime()), 
('wordcategory', 'Word Category', datetime(), datetime());
-----------------------------------------------------------------------------
-----------------------------------------------------------------------------

/* ListItems Seed  
   ListKey = language
*/
-----------------------------------------------------------------------------
-----------------------------------------------------------------------------
INSERT into ListItems (ItemKey, Oridinal, CreatedAt, UpdatedAt, ListId)
VALUES 
('persian', 1, datetime(), datetime(), (select Id from Lists where listkey='language')),
('arabic', 2, datetime(), datetime(), (select Id from Lists where listkey='language')), 
('english', 3, datetime(), datetime(), (select Id from Lists where listkey='language')),
('french', 4, datetime(), datetime(), (select Id from Lists where listkey='language')),
('German', 5, datetime(), datetime(), (select Id from Lists where listkey='language')),
('turkish', 6, datetime(), datetime(), (select Id from Lists where listkey='language')), 
('Azerbaijani', 7, datetime(), datetime(), (select Id from Lists where listkey='language')),
('russian', 8, datetime(), datetime(), (select Id from Lists where listkey='language')),
('armenian', 9, datetime(), datetime(), (select Id from Lists where listkey='language'));

/* ListItemCaptions Seed     
   Language = fa
*/
-----------------------------------------------------------------------------
-----------------------------------------------------------------------------
INSERT into ListItemCaptions (Language, Caption, ListItemId)
VALUES 
('fa', 'پارسی', (select Id from ListItems where ItemKey='persian')), 
('fa', 'عربی', (select Id from ListItems where ItemKey='arabic')), 
('fa', 'انگلیسی', (select Id from ListItems where ItemKey='english')),
('fa', 'فرانسوی', (select Id from ListItems where ItemKey='french')),
('fa', 'آلمانی', (select Id from ListItems where ItemKey='German')),
('fa', 'ترکی', (select Id from ListItems where ItemKey='turkish')), 
('fa', 'آذربایجانی', (select Id from ListItems where ItemKey='Azerbaijani')),
('fa', 'روسی', (select Id from ListItems where ItemKey='russian')),
('fa', 'ارمنی', (select Id from ListItems where ItemKey='armenian'));

-----------------------------------------------------------------------------
-----------------------------------------------------------------------------


/* ListItems Seed  
   ListKey = wordcategory
*/
-----------------------------------------------------------------------------
-----------------------------------------------------------------------------
INSERT into ListItems (ItemKey, Oridinal, CreatedAt, UpdatedAt, ListId)
VALUES 
('religious', 1, datetime(), datetime(), (select Id from Lists where listkey='wordcategory')), 
('cultural', 2, datetime(), datetime(), (select Id from Lists where listkey='wordcategory')), 
('administrative', 3, datetime(), datetime(), (select Id from Lists where listkey='wordcategory')),
('commercial', 4, datetime(), datetime(), (select Id from Lists where listkey='wordcategory')),
('scientific', 5, datetime(), datetime(), (select Id from Lists where listkey='wordcategory')),
('military', 6, datetime(), datetime(), (select Id from Lists where listkey='wordcategory')), 
('naturalresources', 7, datetime(), datetime(), (select Id from Lists where listkey='wordcategory')),
('entertainment', 8, datetime(), datetime(), (select Id from Lists where listkey='wordcategory')),
('industrial', 9, datetime(), datetime(), (select Id from Lists where listkey='wordcategory'));

/* ListItemCaptions Seed     
   Language = fa
*/
-----------------------------------------------------------------------------
-----------------------------------------------------------------------------
INSERT into ListItemCaptions (Language, Caption, ListItemId)
VALUES 
('fa', 'دینی',  (select Id from ListItems where ItemKey='religious')), 
('fa', 'فرهنگی', (select Id from ListItems where ItemKey='cultural')), 
('fa', 'دیوانی', (select Id from ListItems where ItemKey='administrative')),
('fa', 'بازرگانی', (select Id from ListItems where ItemKey='commercial')),
('fa', 'دانش و فناوری', (select Id from ListItems where ItemKey='scientific')),
('fa', 'ارتشی', (select Id from ListItems where ItemKey='military')), 
('fa', 'سرچشمه های نیادی', (select Id from ListItems where ItemKey='naturalresources')),
('fa', 'سرگرمی', (select Id from ListItems where ItemKey='entertainment')),
('fa', 'کار و پیشه', (select Id from ListItems where ItemKey='industrial'))

