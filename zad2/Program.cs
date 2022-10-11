void secondnumber()
{
Console.WriteLine("ВВедите число: ");    
int newNumeric = int.Parse(Console.ReadLine());
if (newNumeric>99)
{
    string numericAsString = newNumeric.ToString();
    int result = int.Parse(numericAsString[2].ToString());
    Console.WriteLine($"Result numeric:{result}");
}
else 
Console.WriteLine("Треттьей цифры нет"); 
}

secondnumber();


