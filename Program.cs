int[] myArray = new int[10];
for(int i=0;i<myArray.Length;i++)
{
    Console.Write("Lutfen bir sayi giriniz: ");
    int userInput = Convert.ToInt32(Console.ReadLine());
    myArray[i] = userInput;
}
foreach(var var in myArray)
{
    Console.WriteLine(var);
}


Console.WriteLine("Lutfen bir sayi daha giriniz");
Array.Resize(ref myArray, myArray.Length+1);

myArray[10]=Convert.ToInt32(Console.ReadLine());
Array.Sort(myArray, (a, b) => b.CompareTo(a));
foreach(var var in myArray)
{
    Console.WriteLine(var);
}
