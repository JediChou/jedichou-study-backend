// ++  前置递增  ++x, x值增1, 表达式返回x递增后的新值
//     后置递增  x++, x值增1, 表达式返回x递增前的旧值
// --  前置递减  --x, x值减1, 表达式返回x递减后的新值
//     后置递减  x--, x值减1, 表达式返回x递减前的旧值
class P{static void c(string _){System.Console.Write(_+'\n');}static void Main(){int i,t;
i=10;t=++i;c("i="+i+",t=++i="+t); i=10;t=i++;c("i="+i+",t=i++="+t);
i=10;t=--i;c("i="+i+",t=--i="+t); i=10;t=i--;c("i="+i+",t=i--="+t);}}
