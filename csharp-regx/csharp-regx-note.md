C#字符串和正则表达式参考手册
============================
Jedi Chou, 2016.3.30 17:16

------

# 第1章 系统处理文本的方式

## 1.1 .NET Framework
### 1.1.1 公共语言运行时
### 1.1.2 .NET Framework类库

## 1.2 文本是一种数据类型
### 1.2.1 C#的数据类型
### 1.2.2 字符和字符集
* C#将字符存储为Unicode
* 单个Unicode字符由char值类型表示
* char值类型映射为System.Char
* 一个字符的范围0x0000~0xFFFF
* 示例1：csregx-sample001.cs
* 示例2：csregx-sample002.cs，（备注：“通常的Unicode 16进制格式中的指定输出”）
* 示例3：csregx-sample003.cs，（备注：“同样把给定字符代码从int转换为char，就可以返回该字符码说表示的字符”）
* 示例4：csregx-sample004.cs，（备注：以各种方式将内容写入到二进制文件中，该文件可用VS打开）

### 1.2.3 字符串数据类型

## 1.3 文本存储
### 1.3.1 高速缓存技术
* 微软采用了Unicode字符的Automation表示，也就是BSTR
* Binary Strings，二进制字符串
* Automation字符串高速缓存的大小为60K
* 这意味着首先连接较小的字符串可以显著提高操作性能
```C#
	sLongStr = sLongStr + ("." + Environment.NewLine)
```

### 1.3.2 内置
* CLR自动维护一个称为“内置池”（intern pool）的表

### 1.3.3 其他方法
### 1.3.4 .NET实现
* 示例5：csregx-sample005.cs,（备注：）

## 1.4 字符串操作
### 1.4.1 连接字符串
### 1.4.2 从字符串中提取之串
### 1.4.3 比较字符串
op_Equality() 并不耗费系统资源

### 1.4.4 字符串转换
将数据类型转换为字符串所采用的步骤如下：
1. 基于源数据类型选择转换算法
2. 判断转换后的字符串的大小
3. 为字符串分配内存空间
4. 执行转换算法，生成字符串

### 1.4.5 格式化字符串

## 1.5 字符串用法
### 1.5.1 构建字符串
### 1.5.2 分析字符串
* Split()
* 位置文件(positional file)
* XML分析器（微软的MSXML分析器）
* DOM, SAX

## 1.6 国际化
* 3种办法创建资源文件
  * 文本文件
  * XML文件
  * 二进制资源文件
* 工具: Resource File Generator(Resgen.exe)
* 实验csregx-lab160401-1258：创建基于文本的资源文件
* 实验csregx-lab160402-1259：创建基于XML的资源文件
* 实验csregx-lab160403-1300：创建基于二进制文件的资源文件

## 1.7 小结


------


# 第2章 String类和StringBuilder类

## 2.1 学习本章要用到工具
* Microsoft Shared Source CLI
* MSIL Deisassembler (ildasm.exe)

## 2.2 文本结构
### 2.3.1 内置字符串
### 2.3.2 构建
* 示例6：csregx-sample006.cs,（备注：构建字符串，并用ildasm查看反编译结果，检查其引用方式）

### 2.3.3 字符串转义

## 2.4 StringBuilder类
### 2.4.1 长度和容量
* 示例7：csregx-sample007.cs,（备注：使用StringBuilder）
* 示例7有些问题，要再看一下。sb.length()先变短再变长后，其sb的内容丢失了
* 示例8：csregx-sample008.cs,（备注：观察StringBuilder的Capacity变化）

### 2.4.2 ToString()方法
* 示例9：csregx-sample009.cs，（备注：使用ToString()方法的重载函数）

## 2.5 字符串操作
### 2.5.1 连接字符串
* 示例10：csregx_sample010.cs，（备注：连接字符串）
