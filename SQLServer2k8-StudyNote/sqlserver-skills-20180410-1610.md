# SQL Server Skills

* Author: Jedi Chou
* Date: 2018-4-10 16:11 PM

## Use osql.exe to connect to SQL Server

```bat
osql /Usa /Slocalhost
osql /Usa /psa /Slocalhost
```

## How use TSQL to show databases

```sql
-- use tsql query
select name from master.dbo.sysdatabases

-- use system store procedure
exec sp_databases

-- use sys.databases
select name from sys.databases
```

## Use TSQL to filter system databases

Normal style.

```sql
select name
  from master.dbo.sysdatabases
 where name not IN ('master', 'tempdb', 'model', 'msdb')
```

Filter by dbid field

```sql
select name from master.dbo.databases where dbid > 6
```

## Transact-SQL

包含一系列元素，比如：标识符、数据类型、运算符、表达式、函数和注释等。

* **标识符**

标识符包含的字数必须在1~128之间。对于本地临时表，最多可以有116个字符。

```sql
select * from TableName where keycol = 124
select * from [TableName] where [keycol] = 124
```

### 2.1.2 数据库对象的命名

```sql
[
    服务器名称.[数据库名称].[构架名称].
    | 数据库名称.[属主名称].
    | 属主名称.
]
对象名
```

* 服务器: 远程服务器名称。
* 当对象驻留在SQL Server数据库中时，数据库名称指定该SQL Server数据库的名称。
* 当对象在链接服务器中时则指定OLEDB目录。
* 架构是包含表、视图、过程等数据库对象的容器。

```sql
-- examples
server.database.schema.object
server.database..object
server..schema.object
server...object
database.schema.object
database..object
object
```

### 2.1.3 同义词

* 目的：减少输入。例如：以下可将master.dbo.spt_values简化为MasterValues

```sql
select * from master.dbo.spt_values
select * from MasterValues
```

### 2.1.4 数据类型

* 二进制数据：binary, varbinary, image
* 字符串数据：char, varchar, text
* Unicode数据：nchar, nvarchar, ntext
* 日期和时间数据：datetime, datetime2, smalldatatime, date, time, datetimeoffset
* 数字数据-整型数据：bigint, int, smallint, tinyint
* 数字数据-小数数据：decimal, numeric
* 近似数字数据：float(n), real
* 货币数据：money, smallmoney

### 2.1.5 常量

### 2.1.6 变量

```sql
declare @abc int
set @abc = 2
print @abc
```

@@开头的是全局变量

### 2.1.7 运算符

* 算术运算符：+, -, *, /, %
* 赋值运算符: =
* 位运算符：&, |, ^
