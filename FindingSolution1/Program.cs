using System;
using System.Collections.Generic;

namespace FindingSolution1
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Action<string> display = Console.WriteLine;
      const string originalString = "2491771842155490223116351359624312364528611014378220168235412194624714016711713319814428177371372322483356775157513821213812018915616178169180422057425055702049257200441752021649520319463179155401482271358391661117611818617619918524622611214787196431912247122923132852316022867242822118221107236471216824475181150239121712918214915910923798652331532147215125222170494190146216102161182971832061006216327616919791582131417224013622832171920823414111920188116842613237131811954516213053245241210105361242183110491312860155099247920710123810311423018722589102126931061741129193139134341491423011512712511380881921451541731651085920912215220148";

      Boolean found = false;
      var dico = new Dictionary<int, int>();
      dico = InitDico();
      var tmpString = originalString;
      for (int i = 1; i < 251; i++)
      {
        if (tmpString.Contains(i.ToString()))
        {
          dico.Add(i, i);
          tmpString = Remove(tmpString, i);
        }
      }
      display("Press any key to exit:");
      Console.ReadKey();
    }

    public static string Remove(string str, int i)
    {
      string result = string.Empty;
      //const string source1 =  "12345678910";
      //const string expected = "1245678910";
      result = str.Substring(0, str.IndexOf((char)i) - 1) + 
                str.Substring(str.IndexOf((char)i) + i.ToString().Length);
      return result;
    }

    private static Dictionary<int, int> InitDico()
    {
      var result = new Dictionary<int, int>();
      for (int i = 0; i < 251; i++)
      {
        result.Add(i, i);
      }

      return result;
    }
  }
}