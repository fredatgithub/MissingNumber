using System;
using System.Text;

namespace MissingNumber
{
  internal class Program
  {
    private static void Main()
    {
      Action<string> display = Console.WriteLine;
      /*
       Here's a string with numbers from 1-250 in random order, but it's missing one number. How will you find the missed number?

        The string was given in the comments:
                   2491771842155490223116351359624312364528611014378220168235412194624714016711713319814428177371372322483356775157513821213812018915616178169180422057425055702049257200441752021649520319463179155401482271358391661117611818617619918524622611214787196431912247122923132852316022867242822118221107236471216824475181150239121712918214915910923798652331532147215125222170494190146216102161182971832061006216327616919791582131417224013622832171920823414111920188116842613237131811954516213053245241210105361242183110491312860155099247920710123810311423018722589102126931061741129193139134341491423011512712511380881921451541731651085920912215220148

      With this hint:

      Its length is 640, composed of 45 0's, 155 1's, 106 2's, 55 3's, 55 4's, 46 5's, 43 6's, 45 7's, 45 8's, and 45 9's.
       * */
      const string originalString = "2491771842155490223116351359624312364528611014378220168235412194624714016711713319814428177371372322483356775157513821213812018915616178169180422057425055702049257200441752021649520319463179155401482271358391661117611818617619918524622611214787196431912247122923132852316022867242822118221107236471216824475181150239121712918214915910923798652331532147215125222170494190146216102161182971832061006216327616919791582131417224013622832171920823414111920188116842613237131811954516213053245241210105361242183110491312860155099247920710123810311423018722589102126931061741129193139134341491423011512712511380881921451541731651085920912215220148";
      string wholeSolution = string.Empty;
      StringBuilder tmpwholeSolution = new StringBuilder();
      for (int i = 1; i < 251; i++)
      {
        tmpwholeSolution.Append(i);
      }

      wholeSolution = tmpwholeSolution.ToString();
      tmpwholeSolution = null;
      int numberOfDigit = wholeSolution.Length - originalString.Length; // 1 ou 2 ou 3
      int solutionNumber = 0;
      for (int i = 1; i < 251; i++)
      {
        if (!originalString.Contains(i.ToString()))
        {
          solutionNumber = i;
          break;
        }
      }

      if (solutionNumber == 0)
      {
        display("pas de solution trouvée");
      }
      else
      {
        display($"the solution is {solutionNumber}");
      }
      
      display("Press any ley to exit:");
      Console.ReadKey();
      /*
       Second hint:
       The quickest and easiest way to find the missing letter is to notice differences in the number counts. Here are some observations that can be made:

      There are 9+90*2+151*3=642 digits from 1 to 250, but the string only has 640 digits. Thus, the missing number has 2 digits
      The numbers are from 1 to 250, meaning that it must be identical for digits between 6 and 9. However, we’re given that there are 43 6’s, and 45 of the other numbers.

      Combining these 2 facts, the missing number is 66.
       * */
    }
  }
}