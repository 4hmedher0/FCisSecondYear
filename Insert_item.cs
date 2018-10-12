using System;
					
public class Program
{
	public static void Main()
{
        
	Console.WriteLine("\"go to go ");
 int [] arr =new int[] {2,4,7,9,0,0};
 int real_items=4;
 int pos=2;//حدد الموقع 
 if(real_items<arr.Length) //#تتاكد ان في عنصر فاضي في المصفوفة
{ real_items++; //اقف علي اول مكان فاضي عشان تشفت فيه
for(int i=real_items;i>pos;i--)//
    {
      arr[i]=arr[i-1];//هتنسخ العنصر الاخير في اول عنصر فاضي 
    
    }
    arr[pos]=88;// ضيف بقي اللي عاوزه في المكان كدة بقي يعتبر فاضي 
    
}
for(int i=0;i<arr.Length;i++)
{
Console.WriteLine(arr[i]);
}

	}

	

}
