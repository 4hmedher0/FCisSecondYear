using System;
					
public class Program
{
	public static void Main()
	{//swaping Task
		Console.WriteLine("Hello World");
		int a,b,temp;
		a=10;b=20;
	Console.WriteLine("a value is: {0:d2} , b value is :{1:d2} ",a,b);
		temp=a;
		a=b;
		b=temp;
	Console.WriteLine("a value is: {0:d2} , b value is :{1:d2}  ",a,b);
	}
}
