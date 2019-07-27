
--Table define
CREATE TABLE status (
  id BIGINT(20) NOT NULL AUTO_INCREMENT,
  name varchar(50) NOT NULL,
  image varchar(100) NOT NULL,
  status varchar(500) NOT NULL,
  timestamp int(11) unsigned NOT NULL,
  PRIMARY KEY (id)
) DEFAULT CHARSET=utf8;

-- Initial data
INSERT INTO status VALUES(null, 'Rintu Raxan', 'rintu.jpg', 'On a day in the year of fox', 1318064723);
INSERT INTO status VALUES(null, 'Aminur Rahman', 'ami.jpg', 'Watching inception first time', 1318064721);
INSERT INTO status VALUES(null, 'Salim Uddin', 'salim.jpg', 'is very busy with my new pet project smugBox', 1318064722);
INSERT INTO status VALUES(null, 'M A Hossain Tonu', 'tonu.jpg', 'Hello this is my AJAX posted status inserted by the StatusPoster PHP class', 1318067362);

-- Query comment
select * from status
