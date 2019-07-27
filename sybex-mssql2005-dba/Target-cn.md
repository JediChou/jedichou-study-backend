SQL Server 2005 实施和维护考试目标
===============================

## 安装与配置
* 确认安装的前置条件
* 从前述版本进行升级
* 创建一个实例
* 配置日志文件和数据文件
* 设置SQLiMail子系统
* 选择数据库的恢复模式
* 配置服务器安全主体
* 配置服务器安装对象
* 确认额外的数据资源
* 确认数据源的角色
* 确认数据源的安全模型

## 实现高可用
* Distinguish between replication types.
* Configure a publisher, a distributor, and a subscriber.
* Configure replication security.
* Configure conflict resolution settings for merge replication.
* 监控恢复
* 准备使用数据库镜像
* 创建数据库服务端点
* Specify database partners.
* Specify a witness server.
* 配置操作模式
* Initialize a secondary database.
* 设置Log-Shipping参数
* 配置Log-Shipping模式
* 配置监控
* 创建快照
* 从快照恢复数据库

## 使用数据
* 执行SQL语句
* 对查询结果进行格式化
* 对查询结果进行排序
* 数据的更新和删除
* 处理异常和错误
* 管理事务
* Identify the specific structure needed by a consumer.
* Retrieve XML data.
* 修改XML数据
* Convert between XML data and relational data.
* 创建XML索引
* Load an XML schema.
* Create an HTTP endpoint.
* Secure an HTTP endpoint.
* 创建服务
* 创建序列
* 创建约束
* Create conversations.
* 创建消息类型
* 将消息发向服务
* Set a database to the Bulk-Logged recovery model to avoid inflating the transaction log.
* 使用bcp工具集
* 执行批量数据的导入
* Import bulk XML data by using the OPENROWSET function.
* 用OPENROWSET执行批量的XML数据导入
* Copy data from one table to another by using the SQL Server 2005 Integration Services (SSIS) Import and Export Wizard.

## 维护数据库
* Set a job owner.
* 创建作业排程
* 创建作业步骤
* 设置作业步骤
* 禁用作业
* 创建维护作业
* Set up alerts.
* Configure operators.
* Modify a job.
* Delete a job.
* Manage index fragmentation.
* Manage statistics.
* Shrink files.
* Perform database integrity checks by using DBCC CHECKDB.
* Perform a full backup.
* Perform a differential backup.
* Perform a transaction log backup.
* Initialize a media set by using the FORMAT option.
* Append or overwrite an existing media set.
* Create a backup device.
* Identify which files are needed from the backup strategy.
* Restore a database from a single file and from multiple files.
* Choose an appropriate restore method.
* Choose an appropriate method for moving a database.

## 数据库的监控和故障排除
* Start a new trace.
* Save the trace logs.
* Configure SQL Server Profiler trace properties.
* Configure a System Monitor counter log.
* Correlate a SQL Server Profiler trace with System Monitor log data.
* Build a workload file by using SQL Server Profiler.
* Tune a workload file by using the Database Engine Tuning Advisor.
* Save recommended indexes.
* Identify the cause of a block by using the sys.dm_exec_requests system view.
* Terminate an errant process.
* Configure SQL Server Profiler trace properties.
* Connect to a nonresponsive server by using the Dedicated Administrator Connection (DAC).
* Review SQL Server start-up logs.
* Review error messages in event logs.
* Identify the cause of a failure.
* Identify outcome details.
* Find out when a job last ran.

## 创建数据库对象
* Specify column details.
* Specify the file group.
* Assign permissions to a role for tables.
* Specify a partition scheme when creating a table.
* Create an indexed view.
* Create an updateable view.
* Assign permissions to a role or schema for a view.
* Create a trigger.
* Create DDL triggers for responding to database structure changes.
* Identify recursive triggers.
* Identify nested triggers.
* Create a function.
* Identify deterministic versus nondeterministic functions.
* Create a stored procedure.
* Recompile a stored procedure.
* Assign permissions to a role for a stored procedure.
* Specify the scope of a constraint.
* Create a new constraint.
* Specify the filegroup.
* Specify the index type.
* Specify relational index options.
* Specify columns.
* Specify a partition scheme when creating an index.
* Disable an index.
* Create an online index by using an ONLINE argument.
* Create a Transact-SQL user-defined type.
* Specify details of the data type.
* Create a CLR user-defined type.
* Create a catalog.
* Create an index.
* Specify a full-text population method.