using System;

class Program {
    static void Main(string[] args) {
Console.WriteLine("Исходный массив");
    Console.WriteLine("hello 2 world :-)");
    
    string [] array = {"hello","2","world",":-)"};

    Console.WriteLine("Выборка");
      for (int i=0;i<=array.Length;i++) {
         
        string a = array[i];
        if (a.Length <= 3) {

        string []result = (string [])array.Clone();

        string b = result[i];
        

        Console.Write(b + " ");
        }
      }
    }
}