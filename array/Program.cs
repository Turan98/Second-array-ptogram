int [] array;
int a;
Console.Write("Enter amount elements of array: ");
a = Convert.ToInt32(Console.ReadLine());
array = new int [a];
Console.WriteLine("Enter elements of array: ");
for (int i = 0; i < array.Length; i++)
{
   array[i] = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Element of array under index [" + i + "] : " + array[i]);
   
   
}
Console.WriteLine("The Sum of the even elements of the array: " + array.Where(i => i %2 ==0).Sum());
Console.WriteLine("The Sum of the odd elements of the array: " + array.Where(i => i %2 !=0).Sum());
Console.WriteLine("The Max element of the array among odd numbers: " + array.Where(i => i %2 !=0).Max());
Console.WriteLine("The Min element of the array among even numbers: " + array.Where(i => i%2==0).Min());
Console.WriteLine();
IEnumerable<int> result = array.Distinct();
foreach (int item in result)
{
   Console.WriteLine(item);
}





 



  

  






