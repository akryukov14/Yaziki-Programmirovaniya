using System;
using System.Collections;

namespace prak_4_03
{
  class Program
  {
    static void Main(string[] args)
    {
      Hashtable lookup = new Hashtable();

      lookup["0"] = "ноль";
      lookup["1"] = "one";
      lookup["2"] = "два";
      lookup["3"] = "три";
      lookup["4"] = "four";
      lookup["5"] = "five";
      lookup["6"] = "шесть";
      lookup["7"] = "семь";
      lookup["8"] = "eight";
      lookup["9"] = "девять";
      lookup["+"] = "плюс";

      string ourNumber = "+7915-157-3100";
      foreach (char c in ourNumber)
      {
        string digit = c.ToString();
        if (lookup.ContainsKey(digit))
        {
          Console.WriteLine(lookup[digit]);
        }
      }

    }
  }
}