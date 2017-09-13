using System;

namespace CreateSolution
{
  class Program
  {
    static void Main()
    {
      Action<string> display = Console.WriteLine;
      string solution1 = string.Empty;
      string[] array1 = new string[250];
      for (int i = 1; i < 251; i++)
      {
        solution1 += i;
        array1[i] = i.ToString();
      }

      
      display("Press any key to exit:");
      Console.ReadKey();
    }
  }
}