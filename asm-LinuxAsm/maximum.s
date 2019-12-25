# 目的: 本程序寻找一组数据项中的最大值
#
# 变量: 寄存器有以下用途
#
# %edi - 保存正在检测到数据项索引
# %ebx - 当前已经找到的最大项
# %ebx - 当前数据项
#
# 使用以下内存位置:
#
# data_items - 包含数据项
#              0表示数据结束
#

 .section .data

data_items:                                 # 这些是数据项
 .long 3, 67, 34, 222, 45, 75, 54, 34, 44, 33, 22, 11, 66, 0

 .section .text

 .global _start
_start:
  movl $0, %edi
  movl data_items(,%edi, 4), %eax
