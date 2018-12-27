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
('persian', 1, datetime(), datetime(), 1), --(select Id from Lists where listkey='language')
('arabic', 2, datetime(), datetime(), 1), 
('english', 3, datetime(), datetime(), 1),
('french', 4, datetime(), datetime(), 1),
('German', 5, datetime(), datetime(), 1),
('turkish', 6, datetime(), datetime(), 1), 
('Azerbaijani', 7, datetime(), datetime(), 1),
('russian', 8, datetime(), datetime(), 1),
('armenian', 9, datetime(), datetime(), 1);

/* ListItemCaptions Seed     
   Language = fa
*/
-----------------------------------------------------------------------------
-----------------------------------------------------------------------------
INSERT into ListItemCaptions (Language, Caption, ListItemId)
VALUES 
('fa', 'پارسی',   1), 
('fa', 'عربی',   2), 
('fa', 'انگلیسی',   3),
('fa', 'فرانسوی',   4),
('fa', 'آلمانی',   5),
('fa', 'ترکی',   6), 
('fa', 'آذربایجانی',   7),
('fa', 'روسی',   8),
('fa', 'ارمنی',   9);

-----------------------------------------------------------------------------
-----------------------------------------------------------------------------


/* ListItems Seed  
   ListKey = wordcategory
*/
-----------------------------------------------------------------------------
-----------------------------------------------------------------------------
INSERT into ListItems (ItemKey, Oridinal, CreatedAt, UpdatedAt, ListId)
VALUES 
('religious', 1, datetime(), datetime(), 2), --(select Id from Lists where listkey='wordcategory')
('cultural', 2, datetime(), datetime(), 2), 
('administrative', 3, datetime(), datetime(), 2),
('commercial', 4, datetime(), datetime(), 2),
('scientific', 5, datetime(), datetime(), 2),
('military', 6, datetime(), datetime(), 2), 
('naturalresources', 7, datetime(), datetime(), 2),
('entertainment', 8, datetime(), datetime(), 2),
('industrial', 9, datetime(), datetime(), 2),
('jobs', 9, datetime(), datetime(), 2);

/* ListItemCaptions Seed     
   Language = fa
*/
-----------------------------------------------------------------------------
-----------------------------------------------------------------------------
INSERT into ListItemCaptions (Language, Caption, ListItemId)
VALUES 
('fa', 'دینی',  (select Id from ListItems where ListItemId=10)), 
('fa', 'فرهنگی', (select Id from ListItems where ListItemId=11)), 
('fa', 'دیوانی', (select Id from ListItems where ListItemId=12)),
('fa', 'بازرگانی', (select Id from ListItems where ListItemId=13)),
('fa', 'دانش و فناوری', (select Id from ListItems where ListItemId=14)),
('fa', 'ارتشی', (select Id from ListItems where ListItemId=15)), 
('fa', 'منابع طبیعی', (select Id from ListItems where ListItemId=16)),
('fa', 'سرگرمی', (select Id from ListItems where ListItemId=17)),
('fa', 'صنعت', (select Id from ListItems where ListItemId=18)),
('fa', 'کار و پیشه', (select Id from ListItems where ListItemId=19))

