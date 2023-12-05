using System;
using System.Text;

class TestClass
{
    static void Main(string[] args)
    {
        // Display the number of command line arguments.
        trythis("001255543");
    }

    public static void trythis(string num)
    {
        //build a list to store all numbers in
        List<int> numList = new List<int>();
        int.Parse(num);
        string subString = "";
        foreach (int number in num)
        {
            var temp = number - 48;
            numList.Add(temp);
            Console.Write(temp);
        }
        foreach (int number in numList)
        {
            if (numList[number] != 0)
            { 
                bool isEqual = numList[number] == numList[number - 1];
                if (isEqual == true)
                {
                    Console.WriteLine($"{number} has potential");
                    var possibleSubString = number.ToString(); 
                    var builder = new StringBuilder();
                    foreach(var c in possibleSubString)
                    {
                        builder.Append(c);
                        if(builder.Length == 3)
                        {
                            subString = builder.ToString();
                        }
                    }
                    
                }
            }
           // Console.WriteLine(number);
        }

        Console.WriteLine(subString);
    }
}
