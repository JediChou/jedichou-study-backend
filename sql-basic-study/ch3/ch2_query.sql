select * from books.dbo.authors
select * from books.dbo.publishers
select * from books.dbo.royalities
select * from books.dbo.title_authors
select * from books.dbo.titles

-- basic select
select city from authors
select au_fname, au_lname, city, state, zip from authors
select * from authors

-- use alias
select 
	au_fname as 'first_name', 
	au_lname as 'last_name',
	city as 'City',
	state,
	zip as 'Postal code'
from authors

-- use distinct
-- Jedi: distinct will use some memory, so don't use it if necessnary
select distinct state from authors
select distinct city, state from authors
select distinct * from authors

-- use order by
select au_fname, au_lname, city, state from authors order by au_lname asc
select au_fname, au_lname, city, state from authors order by state asc, city desc

select au_fname, au_lname, city, state
  from authors
  order by 4 asc, 2 desc  /* order by col number */

select pub_id, state, country
from publishers
order by state asc

select city, state from authors order by zip asc -- zip col don't show

select
  au_fname as 'first name',
  au_lname as 'last name',
  state
from authors
order by
  state asc,
  'last name' asc,
  'first name' asc  -- use alias to execute order by

select title_id, price, sales, price * sales as 'revenue'
from titles
order by 'revenue' desc;

-- use where to filter cols

-- show all authors excetp Hull . lab 4-18
select au_id, au_fname, au_lname from authors where au_lname <> 'Hull'

-- show books that has no signed contract. lab 4-19
select title_name, contract from titles where contract = 0

-- show books that publish after 2001.1. lab 4-20
select title_name from titles where pubdate >= '2001-01-01'

-- show books that revenue greater than 1 million dollas. lab 4-21
select title_name, price * sales as 'revenue' from titles
where price * sales > 1000000

-- special
select *
  from ( select sales as copies_sold from titles) ta
  where copies_sold > 100000
  
-- lab 4-22, show books that price less than 20 dollas
select title_name, type, price
  from titles
 where type = 'biography' and price < 20
 
-- lab 4-23 show authors that don't live at CA and name begin with H to Z
select au_fname, au_lname
  from authors
 where au_lname >= 'H' and au_lname <= 'Z' and state <> 'CA'
 
-- lab 4-24 show authors that live at NY or CO, or live at San Francisco
select au_fname, au_lname from authors
where state = 'NY' or state = 'CO' or city = 'San Francisco'

-- special for NOT. example: show books that price <= 20 dollars
/* correct */
select title_id, type, price from titles
where not type = 'biography'
  and not price < 20
/* wrong */
select title_id, type, price from titles
where not type = 'biography'
  and price < 20
  
-- lab 4-26 列出不居住在加利福利亞州的作者.
select au_id, au_fname, au_lname from authors where not (state = 'CA')

-- lab 4-27 列出價格不低於20美元，並且已售出超過15000的圖書的書名
select title_name, sales, price from titles where not (price < 20) and sales > 15000

-- lab 4-28
-- 如果想列出價格低於20美元的歷史類和傳記類圖書, 這個查詢將不能得出想要的結果,
-- 因為AND比OR有更高的優先級。結果見圖4-28
select *
  from titles
 where type = 'history'
    or type = 'biography'
   and price < 20
   
-- lab 4-29
-- 要修復4-28, 可增加括號以強制OR在AND之前計算
select title_id, type, price
  from titles
 where ( type = 'history' or type = 'biography' )
   and price < 20
   
-- important rule --
-- todo: Homework, how to prove it.
-- NOT (NOT p) -> p
-- NOT (p AND q) -> (NOT p) OR (NOT q)
-- NOT (p OR q) -> (NOT p) AND (NOT q)
-- p AND (q OR r) -> (p AND q) OR (p AND r)
-- p OR ( q AND r) -> (p OR q) AND (p OR r)


-- 