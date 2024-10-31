using System;

public class Program 
{
    public static void Main(string[] args)
    {   
        Write1ThroughN_While(-6);
        Write1ThroughN_For(5);
        WriteNThrough1_While(4);
        WriteNThrough1_For(3);
        WriteEvensThrough100(100);
        FindSum(4);
        FindSumOfEvenNumbers(14);
        FindSumOfOddNumbers(7);
        OutputRightTriangle(-8); 

    }
    public static void Write1ThroughN_While(int n) 
    {   
        int i = 0;
        while (i <= n)
        {
            Console.WriteLine(i);
            i++;
        }
        if (n < 1)
        {
            OutOfRangeMessage(n);
        }
    }
    public static void Write1ThroughN_For(int n)
    {
        for (int i = 0 ; i <= n; i++) 
        {
            Console.WriteLine(i);
        }
         if (n < 1)
        {
            OutOfRangeMessage(n);
        }
    }
    public static void WriteNThrough1_While(int n)
    {
        int i = 0;
        while (i <= n)
        {
            Console.WriteLine(n);
            n--;
        }
         if (n < 1)
        {
            OutOfRangeMessage(n);
        }
    }
    public static void WriteNThrough1_For(int n)
    {
        for (int i = 0; i <= n; n--)
        {
            Console.WriteLine(n);
        }
         if (n < 1)
        {
            OutOfRangeMessage(n);
        }
    }
    public static void WriteEvensThrough100(int n)
    {
        for (int i = 0; i <= 100; i = i + 2)
        {
          Console.WriteLine(i);
        }
    }
    public static void FindSum(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
            sum += i;
        }
        Console.WriteLine(sum);
    }
    public static void FindSumOfEvenNumbers(int n)
    {
       int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 1)
            {
                continue;
            }
            Console.WriteLine(i);
            sum += i;
        }
        Console.WriteLine(sum);
    }
    public static void FindSumOfOddNumbers(int n)
    {
         int sum = 0;
        for (int i = 0; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                continue;
            }
            Console.WriteLine(i);
            sum += i;
        }
        Console.WriteLine(sum);
    }
    public static void OutputRightTriangle(int _base)
    {
       for (int i = 1; i <= _base; i++)  
         { 
            for (int k = 1; k <= i; k++)  
            {  
               Console.Write("*"); 
            }  
            Console.WriteLine("");
         }  
         if (_base < 0)
         {

         for(int i = _base; i <= 0; i++)
         {
            for(int k = i; k <= 0; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
         }

         }
         
    }
    public static void OutOfRangeMessage(int n)
    {
        
        Console.WriteLine(n + " is out of range");
        
    }
}