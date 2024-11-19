using System;

public class AccessModifierExample
{
   
    public int Add(int x, int y)
    {
        return x + y;
    }

   
    private void PrintResult(int result)
    {
        Console.WriteLine($"Результат: {result}");
    }

    public static void Main(string[] args)
    {
        AccessModifierExample example = new AccessModifierExample();

       
        int sum = example.Add(7, 3);
        Console.WriteLine($"Сумма 7 + 3 = {sum}"); 

       
        example.PrintResult(sum);
    }
    

}