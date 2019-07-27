-- For Oracle Express
-- from Oracle Database 10G - The complete reference

drop table newspaper;
commit;

create table newspaper (
	Feature varchar2(15) not null,
	Section char(1),
	Page number
);

insert into newspaper values('Nation News', 'A', 1);
insert into newspaper values('Sports', 'D', 1);
insert into newspaper values('Editorials', 'A', 12);
insert into newspaper values('Business', 'E', 1);
insert into newspaper values('Weather', 'C', 2);
insert into newspaper values('Television', 'B', 7);
insert into newspaper values('Births', 'F', 7);
insert into newspaper values('Classified', 'F', 8);
insert into newspaper values('Modern Life', 'B', 1);
insert into newspaper values('Comics', 'C', 4);
insert into newspaper values('Movies', 'B', 4);
insert into newspaper values('Bridge', 'B', 2);
insert into newspaper values('Obituaries', 'F', 6);
insert into newspaper values('Doctor Is In', 'F', 6);
	
commit;