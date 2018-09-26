using System;

namespace CreateSolution
{
  internal class Program
  {
    private static void Main()
    {
      Action<string> display = Console.WriteLine;
      string solution1 = string.Empty;
      var array1 = new string[251];
      for (int i = 1; i < 251; i++)
      {
        solution1 += i;
        array1[i] = i.ToString();
      }

      display($"La chaine créée est {solution1}");
      
      display("Press any key to exit:");
      Console.ReadKey();
    }
  }
}