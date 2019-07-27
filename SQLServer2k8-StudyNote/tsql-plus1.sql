-- file: tsql-plus1.sql
-- desc: how to use plus operator

use master
go

declare @var1 int = 100
declare @var2 int = 50
select (@var1 + @var2) as result
go
