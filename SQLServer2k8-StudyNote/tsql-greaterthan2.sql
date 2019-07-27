use master
go

declare @a int = 45
declare @b int = 40

select 
  case when @a > @b then 'TRUE'
    else 'FALSE'
  end as Result;
go
