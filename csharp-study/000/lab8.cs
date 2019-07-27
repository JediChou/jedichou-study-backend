namespace lab8
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	
	public class lab8
	{
		public static void Main(string[] args)
		{
			// 8个预定义整数类型
			sbyte	type_sbyte	= 1;
			short	type_short	= 1;
			int		type_int	= 1;
			long	type_long	= 1;
			byte	type_byte	= 1;
			ushort	type_ushort	= 1;
			uint 	type_uint	= 1;
			ulong	type_ulong	= 1;
			
			// 2个浮点类型
			float	type_float	= 1.0F;
			double	type_double	= 1.0;
			
			// 1个decimal类型
			decimal	type_decimal = 1.0M;
			
			// bool类型
			bool	type_bool	= true;
			
			// char类型
			char	type_char	= 'A';
			
			// 定义一个List
			List<Object> lstTypeList = new List<Object>() ;
			lstTypeList.Add(type_sbyte);
			lstTypeList.Add(type_short);
			lstTypeList.Add(type_int);
			lstTypeList.Add(type_long);
			lstTypeList.Add(type_byte);
			lstTypeList.Add(type_ushort);
			lstTypeList.Add(type_uint);
			lstTypeList.Add(type_ulong);
			lstTypeList.Add(type_float);
			lstTypeList.Add(type_double);
			lstTypeList.Add(type_decimal);
			lstTypeList.Add(type_bool);
			lstTypeList.Add(type_char);
			
			foreach(Object elt in lstTypeList)
				Console.WriteLine( lstTypeList.IndexOf(elt) + 1 + "-" + getType(elt) + ", value:" + elt.ToString());
		}
		
		// Help method
		public static string getType(Object obj)
		{
			return obj.GetType().ToString();
		}
	}
}
