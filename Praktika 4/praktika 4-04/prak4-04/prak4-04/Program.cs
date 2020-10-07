using System;
using System.Collections;
using System.Collections.Specialized;
using System.Globalization;

namespace prak_4_04
{
  class Program
  {
    static void Main(string[] args)
    {
      ListDictionary list = new ListDictionary(new CaseInsensitiveComparer(CultureInfo.InvariantCulture));
      list["Estados Unidos"] = "United States of America";
      list["UNITED KINGDOM"] = "United Kingdom";
      list["italia"] = "Italy";
      Console.WriteLine(list["UNITED KINGDOM"]);
      Console.WriteLine(list["italia"]);
      Console.Read();
    }

  }

}