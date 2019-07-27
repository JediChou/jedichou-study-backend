package ch4.corejava;

import java.util.Date;

/**
 * 使用Date对象进行输出 
 * @author Jedi Chou
 */
public class UseDate {
	public static void main(String[] args) {
		// 直接打印Date对象的输出值
		System.out.println(new Date());
		
		// 间接调用Date对象的输出值
		String s = new Date().toString();
		System.out.println(s);
		
		// 先定义，然后初始化，最后输出
		Date deadline;
		deadline = new Date();
		System.out.println(deadline);
	}
}
