SQL Server 2008 技术内幕
========================

## 第一章  T-SQL查询和编程基础

### 1.1 理论背景
* [ ] 1.1.1 SQL
* [ ] 1.1.2 集合论
* [ ] 1.1.3 谓词逻辑
* [ ] 1.1.4 关系模型
  - [ ] 第一范式
  - [ ] 第二范式
  - [ ] 第三范式
  - [ ] 第四范式
* [ ] 1.1.5 数据生命周期
  - [ ] 联机事务处理
  - [ ] 数据仓库
  - [ ] 联机分析处理
  - [ ] 数据挖掘
  
### 1.2 SQL Server体系结构
* [ ] 1.2.1 SQL Server实例
* [ ] 1.2.2 数据库
  - [ ] default: master
  - [ ] default: Resource
  - [ ] default: model
  - [ ] default: tempdb
  - [ ] default: msdb
  - [ ] 文件扩展名: .mdf, .ldf, .ndf
* [ ] 1.2.3 架构(Schema)对象
  - [ ] schema-qualified
  - [ ] two-part name

### 1.3 创建表和定义数据完整性
* [ ] 1.3.1 创建表
* [ ] 1.3.2 定义数据完整性
  - [ ] 声明式 (declarative)
  - [ ] 过程式 (procedural)
  - [ ] 主键约束 (primary key constraints)
  - [ ] 唯一约束 (unique constraints)
  - [ ] 引用表 (referencing table)
  - [ ] 检查约束 (check)

### 1.4 总结
* [ ] Jedi: 明确后续的target
  - [ ] 学习列表极其重点

	
## 第二章 单表查询

### 2.1 Select 语句的元素
* [ ] 实验sqlab0201
  - [ ] schema: schema0201.sql
  - [ ] sqlcode0201.sql 
* [ ] 执行次序: from->where->group by->having->select->order by (Jedi: 如何证明？)

* [ ] 2.1.1 from子句
* [ ] 2.1.2 where子句
* [ ] 2.1.3 group by子句
* [ ] 2.1.4 having子句
* [ ] 2.1.5 select子句
  - [ ] sqlab0202
  - [ ] sqlab0203
* [ ] 2.1.6 order by子句
  - [ ] sqlab0204
* [ ] 2.1.7 top选项
  - [ ] sqlab0205
  - [ ] sqlab0206
* [ ] 2.1.8 over子句

### 2.2 谓词和运算符
* [ ] 优先级
  - [ ] ()
  - [ ] *,/,%
  - [ ] +, -, +, -
  - [ ] =,>,<,>=,<=,<>,!=,!>,!<
  - [ ] not
  - [ ] and
  - [ ] between, in, like, or
  - [ ] =

### 2.3 Case表达式
* [ ] 简单表达式, 搜索表达式

### 2.4 NULL值

### 2.5 同时操作(All-AT-Once Opertion)

### 2.6 处理字符数据(数据类型， 数据规则，运算符和函数)
* [ ] 2.6.1 数据类型
* [ ] 2.6.2 排序规则
* [ ] 2.6.3 运算符和函数
  - [ ] substring
  - [ ] left
  - [ ] right
  - [ ] len
  - [ ] charindex
  - [ ] patindex
  - [ ] replace
  - [ ] replicate
  - [ ] stuff
  - [ ] upper
  - [ ] lower
  - [ ] rtrim
  - [ ] ltrim
* [ ] 2.6.4 like谓词
  - [ ] % 百分号通配符
  - [ ] _ 下划线通配符
  - [ ] [<字符列>]通配符
  - [ ] [<字符>-<字符>]通配符
  - [ ] [^<字符列或范围>]通配符
  - [ ] ESCAPE(转义)字符
  
### 2.7 处理日期和时间数据

* [ ] 2.7.1 日期和时间数据类型
  - [ ] datetime
  - [ ] smalldatetime
  - [ ] time
  - [ ] datetime2
  - [ ] datetimeoffset

* [ ] 2.7.2 字符串文字
* [ ] 2.7.3 单独使用日期和时间
* [ ] 2.7.4 过滤日期范围

* [ ] 2.7.5 日期和时间函数
  - [ ] GetDate
  - [ ] Current_Timestamp
  - [ ] GetUTCdate
  - [ ] Sysdatetime
  - [ ] SysUCTDatetime
  - [ ] SysDateTimeOffset
  - [ ] Cast
  - [ ] Convert
  - [ ] SwitchOffset
  - [ ] TodayTimeoffset
  - [ ] DateAdd
  - [ ] DateDiff
  - [ ] DatePart
  - [ ] Year
  - [ ] Month
  - [ ] Day
  - [ ] DateName
  
### 2.8 查询元数据
* [ ] 2.8.1 目录视图
* [ ] 2.8.2 信息架构视图
* [ ] 2.8.3 系统存储过程和函数

### 2.9 总结

### 2.10 练习
* [ ] 前置条件: TSQLfundamentals2008
* [ ] LabEx0201
* [ ] LabEx0202
* [ ] LabEx0203
* [ ] LabEx0204
* [ ] LabEx0205
* [ ] LabEx0206
* [ ] LabEx0207
* [ ] LabEx0208

### 2.11 解决方案
* [ ] LabSln0201
* [ ] LabSln0202
* [ ] LabSln0203
* [ ] LabSln0204
* [ ] LabSln0205
* [ ] LabSln0206
* [ ] LabSln0207
* [ ] LabSln0208
	
##	第三章 联接查询

### 3.1 交叉联接
* [ ] 3.1.1 ANSI SQL-92
* [ ] 3.1.2 ANSI SQL-89
* [ ] 3.1.3 自交叉联接
* [ ] 3.1.4 生成数字表

### 3.2 内联接
* [ ] 3.2.1 ANSI SQL-92
* [ ] 3.2.2 ANSI SQL-89
* [ ] 3.2.3 更安全的内联接

### 3.3 特殊的联接实例
* [ ] 3.3.1 组合联接
* [ ] 3.3.2 不等联接
* [ ] 3.3.3 多表联接

### 3.4 外连接
* [ ] 3.4.1 外联接基础

* [ ] 3.4.2 外联接的高级主题
  - [ ] 包含缺少值的数据
  - [ ] 对外联接中非保留表的列值进行过滤
  - [ ] 在多表联接中使用外联接
  - [ ] 随外联接一起使用COUNT聚合函数

### 3.5 总结

### 3.6 练习
* [ ] 前置条件: TSQLfundamentals2008
* [ ] LabEx030101
* [ ] LabEx030102
* [ ] LabEx030103
* [ ] LabEx0302
* [ ] LabEx0303
* [ ] LabEx0304
* [ ] LabEx0305
* [ ] LabEx0306
* [ ] LabEx0307

### 3.7 解决方案
* [ ] LabSln030101
* [ ] LabSln030102
* [ ] LabSln030103
* [ ] LabSln0302
* [ ] LabSln0303
* [ ] LabSln0304
* [ ] LabSln0305
* [ ] LabSln0306
* [ ] LabSln0307
	
##  第四章 子查询

### 4.1 独立子查询
* [ ] 4.1.1 独立标量子查询
* [ ] 4.1.2 独立多值子查询

### 4.2 相关子查询
* [ ] 4.2.1 exists谓词

### 4.3 高级子查询
* [ ] 4.3.1 返回前一个或后一个记录
* [ ] 4.3.2 连续聚合(running aggregate)
* [ ] 4.3.3 行为不当(misbehaving)的子查询
  - [ ] null的问题
  - [ ] 子查询列名中的替换错误 

### 4.4 总结

### 4.5 练习
* [ ] LabEx0401
* [ ] LabEx0402
* [ ] LabEx0403
* [ ] LabEx0404
* [ ] LabEx0405
* [ ] LabEx0406
* [ ] LabEx0407
* [ ] LabEx0408

### 4.6 解决方案
* [ ] LabSln0401
* [ ] LabSln0402
* [ ] LabSln0403
* [ ] LabSln0404
* [ ] LabSln0405
* [ ] LabSln0406
* [ ] LabSln0407
* [ ] LabSln0408


## 第五章 联接查询

### 5.1 派生表

* [ ] 查询语句必须满足3个要求
  - [ ] 不保证有一定的顺序
  - [ ] 所有的列必须有名称
  - [ ] 所有的列名必须是唯一
  
* [ ] 5.1.1 分配列别名
* [ ] 5.1.2 使用参数
* [ ] 5.1.3 嵌套
* [ ] 5.1.4 派生表的多引用

### 5.2 公用表达式
* [ ] 公用表达式(CTE, Common table expression)
* [ ] 5.2.1 分配列别名
* [ ] 5.2.2 使用参数
* [ ] 5.2.3 定义多个CTE
* [ ] 5.2.4 CTE的多引用
* [ ] 5.2.5 递归CTE

### 5.3 视图
* [ ] 5.3.1 视图和order by子句
* [ ] 5.3.2 视图选项
  - [ ] encryption
  - [ ] schemabinding
  - [ ] check option

### 5.4 内联表值运算符

### 5.5 APPLY运算符

### 5.6 总结

### 5.7 练习
* [ ] LabEx050101
* [ ] LabEx050102
* [ ] LabEx050201
* [ ] LabEx050202
* [ ] LabEx0503
* [ ] LabEx050401
* [ ] LabEx050402
* [ ] LabEx050501
* [ ] LabEx050502

### 5.8 解决方案	
* [ ] LabSln050101
* [ ] LabSln050102
* [ ] LabSln050201
* [ ] LabSln050202
* [ ] LabSln0503
* [ ] LabSln050401
* [ ] LabSln050402
* [ ] LabSln050501
* [ ] LabSln050502
	
##  第六章 表表达式

### 6.1 UNION(并集)集合运算
* [ ] 6.1.1 Union All集合运算
* [ ] 6.1.2 Union distinct集合运算

### 6.2 Intersect(交集) 集合运算
* [ ] 6.2.1 intersect distinct集合运算
* [ ] 6.2.2 Intersect all集合运算

### 6.3 Intersect Distinct集合运算
* [ ] 6.3.1 EXCEPT Distinct集合运算
* [ ] 6.3.2 Except ALL集合运算

### 6.4 Except(差集)集合运算

### 6.5 避开不支持的逻辑查询处理

### 6.6 总结

### 6.7 练习
* [ ] LabEx0601
* [ ] LabEx0602
* [ ] LabEx0603

### 6.8 解决方案
* [ ] LabSln0601
* [ ] LabSln0602
* [ ] LabSln0603
* [ ] LabSln0604
* [ ] LabSln0605
* [ ] LabSln0606
	
##  第七章 透视、逆透视及分组集

### 7.1 透视转换
* [ ] 7.1.1 使用标准SQL 进行透视转换
* [ ] 7.1.2 使用T-SQL Pivot运算符进行透视转换

### 7.2 逆透视转换
* [ ] 7.2.1 使用标准SQL进行逆透视转换
* [ ] 7.2.2 使用T-SQL的Unpivot运算符进行逆透视转换

### 7.3 分组集
* [ ] 7.3.1 Grouping Sets从属子句
* [ ] 7.3.2 Cube从属子句
* [ ] 7.3.3 Rollup从属子句
* [ ] 7.3.4 grouping和grouping_id函数

### 7.4 总结

### 7.5 练习
* [ ] LabEx0701
* [ ] LabEx0702
* [ ] LabEx0703

### 7.6 解决方案
* [ ] LabSln0701
* [ ] LabSln0702
* [ ] LabSln0703

##  第八章 数据修改

### 8.1 插入数据
* [ ] 8.1.1 insert values语句
* [ ] 8.1.2 insert select语句
* [ ] 8.1.3 insert exec语句
* [ ] 8.1.4 select into语句
* [ ] 8.1.5 bulk insert语句
* [ ] 8.1.6 identity属性

### 8.2 删除数据
* [ ] 8.2.1 delete语句
* [ ] 8.2.2 truncate语句
* [ ] 8.2.3 基于连接的delete

### 8.3 更新数据
* [ ] 8.3.1 update语句
* [ ] 8.3.2 基于联接的update
* [ ] 8.3.4 赋值update

### 8.4 合并数据

### 8.5 通过表表达式修改数据

### 8.6 带有TOP选项的数据更新 

### 8.7 output子句
* [ ] 8.7.1 带有output的insert语句
* [ ] 8.7.2 带有output的delete语句
* [ ] 8.7.3 带有output的update语句
* [ ] 8.7.4 带有output的merge语句
* [ ] 8.7.5 可组合的DML

### 8.8 总结

### 8.9 练习
* [ ] LabEx080101
* [ ] LabEx080102
* [ ] LabEx080103
* [ ] LabEx080104
* [ ] LabEx0802
* [ ] LabEx0803
* [ ] LabEx080401
* [ ] LabEx080402
* [ ] LabEx0805

### 8.10 解决方案
* [ ] LabSln080101
* [ ] LabSln080102
* [ ] LabSln080103
* [ ] LabSln080104
* [ ] LabSln0802
* [ ] LabSln0803
* [ ] LabSln080401
* [ ] LabSln080402
* [ ] LabSln0805

	
##  第九章 事务和并发

### 9.1 事务

### 9.2 锁定和阻塞
* [ ] 9.2.1 锁
  - [ ] 锁模式及其兼容性
  - [ ] 可锁定资源的类型
* [ ] 9.2.2 检测阻塞

### 9.3 隔离级别
* [ ] 9.3.1 read uncommitted未提交读
* [ ] 9.3.2 read committed已提交读
* [ ] 9.3.3 repeatble read可重复读
* [ ] 9.3.4 serializable可序列化
* [ ] 9.3.5 snapshot隔离级别
* [ ] 9.3.6 隔离级别总结

### 9.4 死锁

### 9.5 总结

### 9.6 练习
* [ ] LabEx090101
* [ ] LabEx090102
* [ ] LabEx090103
* [ ] LabEx090104
* [ ] LabEx090105
* [ ] LabEx090106
* [ ] LabEx090201
  - [ ] LabEx090201a
  - [ ] LabEx090201b
  - [ ] LabEx090201c
  - [ ] LabEx090201d
* [ ] LabEx090202
  - [ ] LabEx090202a
  - [ ] LabEx090202b
  - [ ] LabEx090202c
  - [ ] LabEx090202d
  - [ ] LabEx090202e
* [ ] LabEx090203
  - [ ] LabEx090203a
  - [ ] LabEx090203b
  - [ ] LabEx090203c
  - [ ] LabEx090203d
  - [ ] LabEx090203e
* [ ] LabEx090204
  - [ ] LabEx090204a
  - [ ] LabEx090204b
  - [ ] LabEx090204c
  - [ ] LabEx090204d
  - [ ] LabEx090204e
  - [ ] LabEx090204f
* [ ] LabEx090205
  - [ ] LabEx090205a
  - [ ] LabEx090205b
  - [ ] LabEx090205c
  - [ ] LabEx090205d
  - [ ] LabEx090205e
  - [ ] LabEx090205f
  - [ ] LabEx090205g
* [ ] LabEx090206
  - [ ] LabEx090206a
  - [ ] LabEx090206b
  - [ ] LabEx090206c
  - [ ] LabEx090206d
  - [ ] LabEx090206e
  - [ ] LabEx090206f
  - [ ] LabEx090206h
* [ ] LabEx090301
* [ ] LabEx090302
* [ ] LabEx090303
* [ ] LabEx090304
* [ ] LabEx090305
* [ ] LabEx090306
* [ ] LabEx090307


## 第十章  可编辑对象

### 10.1 变量

### 10.2 批处理
* [ ] 10.2.1 批处理是语句分析的单元
* [ ] 10.2.2 批处理和变量
* [ ] 10.2.3 不能再同一批处理中编译的语句
* [ ] 10.2.4 批处理是语句解析的单元
* [ ] 10.2.5 GO n 选项

### 10.3 流程控制元素
* [ ] 10.3.1 IF...ELSE流程控制元素
* [ ] 10.3.2 WHILE流程控制元素
* [ ] 10.3.3 使用IF和WHILE的一个例子

### 10.4 游标

### 10.5 临时表
* [ ] 10.5.1 局部临时表
* [ ] 10.5.2 全局临时表
* [ ] 10.5.3 表变量
* [ ] 10.5.4 表类型

### 10.6 动态SQL
* [ ] 10.6.1 Exec命令
* [ ] 10.6.2 sp_executesql存储过程
* [ ] 10.6.3 在pivot中使用动态SQL

### 10.7 例程
* [ ] 10.7.1 用户定义函数
* [ ] 10.7.2 存储过程
* [ ] 10.7.3 触发器
* [ ] 10.7.4 DML触发器
* [ ] 10.7.5 DDL触发器

### 10.8 错误处理

### 10.9 总结	
	
## 附件 入门手册

### A.1 安全SQL Server 
  - [ ] 获得SQL Server
  - [ ] 创建用户账户
  - [ ] 安装必备组件
  - [ ] 安装数据库引擎、文档及工具

### A.2 下载源代码和安装样例数据库
  - [ ] [本书源代码](http://www.insidetsql.com)
  - [ ] 运行步骤
  - [ ] Schema

### A.3 使用SQL Server Management Studio
### A.4 使用SQL Server联机丛书
