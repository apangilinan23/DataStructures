using static System.Runtime.InteropServices.JavaScript.JSType;

var numbers = new List<int>();
numbers.Add(1);//index 0
numbers.Add(2);//index 1
numbers.Add(3);//index 2

Console.WriteLine("List");
foreach (var number in numbers)
{
    Console.WriteLine(number);
}

var numbersArray = new int[3];
numbersArray[0] = 1;
numbersArray[1] = 2;
numbersArray[2] = 3;

Console.WriteLine("Array");
foreach (var number in numbersArray)
{
    Console.WriteLine(number);
}

var numbersDictionary = new Dictionary<string,int>();
numbersDictionary["one"] = 1;
numbersDictionary["two"] = 2;
numbersDictionary["three"] = 3;

Console.WriteLine("Dictionary");
foreach (var key in numbersDictionary.Keys)
{
    Console.WriteLine(numbersDictionary[key]);
}