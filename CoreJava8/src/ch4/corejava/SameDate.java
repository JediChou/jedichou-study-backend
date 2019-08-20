package ch4.corejava;

import java.util.*;

public class SameDate {

	public static void main(String[] args) {
		
		// 先定义两个Date, 然后使用赋值
		Date currentTime = new Date();
		Date secondTime = currentTime;
		
		// 输出
		System.out.println("CurrentTime: " + currentTime);
		System.out.println("SecondTime: " + secondTime);
		
		// 更改currentTime的值
		currentTime = new Date("2016-10-1");
		
		// 然后再进行输出
		System.out.println("");
		System.out.println("CurrentTime: " + currentTime);
		System.out.println("SecondTime: " + secondTime);
	}
}
