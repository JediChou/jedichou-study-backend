using System;
using System.Linq;
using System.Collections.Generic;

/*
 * ����1.1 �ƽ̨
 *
 * ��֪һ���Ѿ���С������������飬��������е�һ��ƽ̨(Plateau)
 * ����������һ��ֵ��ͬ��Ԫ�أ�������һ��Ԫ�ز��������졣���磬
 * ��1,2,2,3,3,3,4,5,5,6��1,2,2,3,3,3,4,5,5,6����ƽ̨���Ա�дһ��
 * ���򣬽���һ�����飬��������������ƽ̨�ҳ����������������
 * ��3,3,3���Ǹ����������ƽ̨��
 *
 * ˵��
 * �������ʮ�ּ򵥣�����Ҫ��д��ȴ�����ף�����ڱ�д����ʱӦ�ÿ�
 * �����漸��:
 * 1.ʹ�õı���Խ��Խ��;
 * 2.�ܷ�ֻ�������Ԫ��ÿһ����ֻ��һ�ξ͵õ����?
 * 3.�������ҲҪԽ��Խ��
 *
 * ������������Ź�David Gries��λ֪���ļ������ѧ�ң���������ȡ
 * ��David Gries��д���йس�����Ƶ�ר����
 */

class Plateau {
	public static void Main() {
		answer1();
		jedi();
	}
	
	private static void answer1() {
		var arr = new int[] { 1,2,2,3,3,3,4,5,5,6,7,7,7,7,7,8,8,8,8,8 };
		var length = 1;
		for(int i = 1; i < arr.Length; i++)
			if (arr[i] == arr[i-length])
				length++;
		Console.WriteLine(length);
	}
	
	private static void jedi_first() {
		var arr = new int[] { 1,2,2,3,3,3,4,5,5,6,7,7,7,7,7,8,8,8,8,8 };
		var dict = new Dictionary<int, int>();
		var q = from d in dict where d.Value == dict.Values.Max() select d.Key;
		foreach(var elt in arr) dict[elt] = dict.ContainsKey(elt) ? dict[elt]+1 : 1;
		q.ToList().ForEach(t=>Console.WriteLine(t));
	}
}