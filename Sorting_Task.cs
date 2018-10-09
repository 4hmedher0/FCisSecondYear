using System;
					
public class Program
{
	public static void Main()
{
        
int [] m1=new int[] {-1,99,66,0,-99,33,45};
		Sort(m1);

}
	public static void print (int [] m1)
	{
	// print method
for(int i=0;i<m1.Length;i++)
{Console.WriteLine("the index {0} is: {1}",i,m1[i]);}
	}
	public static void Sort(int [] m1)
	{
	
	for (int i = 1; i < m1.Length; i++)
{
 int temp;
    for (int j = 0; j <i; j++)
    {
        if (m1[j]>m1[i])
        {//swap method
        temp=m1[j];
        m1[j]=m1[i];
        m1[i]=temp;
        }
       
    }
} 
		print(m1);
	
	}
}
