using System.Numerics;

TeaCafe.Ordering("");
public class Tea
{
    public static void SugarAdd(bool bol = false) 
    {
        if (bol)
        {
            int a;
            Console.WriteLine("How much spoons of sugar do we need to add in ur tea");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Here's your tea with {a} spoons of sugar");
        }
    } 
}

public class GreenTea : Tea { }
public class BlackTea : Tea { }
public class WhiteTea : Tea { }
public class OrangeTea : Tea { }
public class PinkTea : Tea { }

public class TeaCafe : Tea
{
    public static Tea Ordering(string type)
    {
        Tea tea = null;

        Tea.SugarAdd();
        
        Console.WriteLine("Order your tea");
        Console.WriteLine("1 - Green Tea");
        Console.WriteLine("2 - Black Tea");
        Console.WriteLine("3 - White Tea");
        Console.WriteLine("4 - Orange Tea");
        Console.WriteLine("5 - Pink Tea");

        int i = Convert.ToInt32(Console.ReadLine());

        switch (i)
        {
            case 1:
                type = "Green Tea";
                break;
            case 2:
                type = "Black Tea";
                break;
            case 3:
                type = "White Tea";
                break;
            case 4:
                type = "Orange Tea";
                break;
            case 5:
                type = "Pink Tea";
                break;
        }

        switch (type)
        {
            case "Green Tea":
                tea = new GreenTea();
                break;
            case "Black Tea":
                tea = new BlackTea();
                break;
            case "White Tea":
                tea = new WhiteTea();
                break;
            case "Orange Tea":
                tea = new OrangeTea();
                break;
            case "Pink Tea":
                tea = new PinkTea();
                break;
        }

        Console.Clear();

        Console.WriteLine($"Here's your {tea}");

        Console.WriteLine("Do u want some sugar in your tea? (Yes/No)");
        string sugar = Console.ReadLine().ToLower();

        switch(sugar)
        {
            case "yes":
                Tea.SugarAdd(true);
                break;
            case "no":
                Console.WriteLine($"Here's your {type}");
                break;
        }

        return tea;
    }
}