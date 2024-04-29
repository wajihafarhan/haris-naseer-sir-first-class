// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!")

using System.Xml.Schema;

Console.WriteLine("enter the obtained marks");
	double num = double.Parse(Console.ReadLine());

	Console.WriteLine("enter the Total marks");
	double num1 = double.Parse(Console.ReadLine());
void percentage()
{
	if (num <= num1)
	{
		double percentage = num * 100 / num1;


		Console.WriteLine($"Your percentage  is {double.Round(percentage, 2)}");
	}
	else
	{
		Console.WriteLine("total marks should be less than obtain marks");
	}
}

percentage();


//LIST

List<string> Mobiles = new List<string>();
string userinput;

do
{
    Console.WriteLine("Enter your mobile name");

    userinput = (Console.ReadLine()).ToLower();
    if (userinput != "no")
    {
        Mobiles.Add(userinput);
    }

}
while (userinput != "no");

foreach (var item in Mobiles)
{
    Console.WriteLine(item);
}