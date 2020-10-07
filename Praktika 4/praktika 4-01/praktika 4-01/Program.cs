using System;
using System.Collections;

namespace prakt4_01
{
  class Program
  {

    static void Main(string[] args)
    {
      ArrayList myList = new ArrayList() { "Jora" }                ;
      myList.Add("Andrey");
      myList.Add("Mikhalich");
      myList.Add("Whiskey");
      myList.Add("C#");
      foreach (string item in myList)
      {
        Console.WriteLine("Unsorted: {0}", item);
      }
      // Сортировка при помощи стандартного объекта сравнения 
      myList.Sort();
      //myList.Reverse();
      foreach (string item in myList)
      {
        Console.WriteLine("   Sorted: {0}", item);
      }

    }

  }
}