OReilly Linq in Action
======================

## 4.4 常用的标准查询操作符号
* 按照操作类型分组的标准查询操作符
  - 过滤: ofType, Where
  - 投影: Select, SelectMany
  - 分区: Skip, SkipWhile, Take, TakeWhile
  - 连接: GroupJoin, Join
  - 串联: Concat
  - 排序: OrderBy, OrderByDecending, Reverse, ThenBy, ThenByDescending
  - 分组: GroupBy, ToLookup
  - 集合; Distinct, Except, Intersect, Union
  - 转换: AsEnumerable, AsQueryable, Cast, ToArray, ToDictionary, ToList
  - 等同: SequenceEqual
  - 元素: ElementAt, ElementAtOrDefault, First, FirstOrDefault, Last, LastOrDefault, Single, SingleOrDefault
  - 生成: DefaultIfEmpty, Empty, Range, Repeat
  - 数量: All, Any, Contains
  - 聚集: Aggregate, Average, Count, LongCount, Max, Min, Sum

### 4.4.1 约束操作符Where
* Where操作符的声明
```c#
public static IEnumrable<T> Where<T>(
    this IEnumerable<T> source,
    Func<T, bool> predicate
);
```
* 