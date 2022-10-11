void secondnumber()
{
Console.WriteLine("ВВедите трехзначное число: ");    
int newNumeric = int.Parse(Console.ReadLine());
if (newNumeric>99 && newNumeric<1000)
{
    string numericAsString = newNumeric.ToString();
    int result = int.Parse(numericAsString[1].ToString());
    Console.WriteLine($"Result numeric:{result}");
}
else 
Console.WriteLine("Число не трехзначное "); 
}

secondnumber();

