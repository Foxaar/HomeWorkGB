using System;

class Program {
    static void Main(string[] args) {
Console.WriteLine("Исходный массив");
    Console.WriteLine("hello 2 world :-)");
    
    string [] array = {"hello","2","world",":-)"};

    Console.WriteLine("Выборка");
      for (int i=0;i<=array.Length-1;i++) {
         
        string arrStart = array[i];
        if (arrStart.Length <= 3) {

        string []result = (string [])array.Clone();

        string arrResult = result[i];
        

        Console.Write(arrResult + " ");
        
        }
        
      }
    Console.WriteLine("");
    Console.WriteLine("Конец программы");
    }
}