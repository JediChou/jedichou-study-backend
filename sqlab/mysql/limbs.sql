-- From OReilly MySQL Cookbook 2nd
-- Chapter 1.12

drop table if exists limbs;
create table limbs
(
	thing varchar(20),  # thing field
	legs int, 			# leg numbers
	arms int			# arm numbers
);

insert into limbs values ('human', 2, 2);
insert into limbs values ('insect', 6, 0);
insert into limbs values ('squid', 0, 10);
insert into limbs values ('octopus', 0, 8);
insert into limbs values ('fish', 0, 0);
insert into limbs values ('centipede', 100, 0);
insert into limbs values ('table', 4, 0);
insert into limbs values ('armchair', 4, 2);
insert into limbs values ('phonograph', 0, 1);
insert into limbs values ('tripod', 3, 0);
insert into limbs values ('Peg Leg Pete', 1, 2);
insert into limbs values ('space alien', NULL, NULL);
