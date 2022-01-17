using System;

class Program {
    static void Main(string[] args) {
while(true){
      Console.WriteLine("ГЕНЕРАТОР ПАРОЛЯ");
      Console.WriteLine("---------------");
      Console.WriteLine("Количество символов в пароле");
      int i = int.Parse(Console.ReadLine());
      Console.WriteLine("Большие символы 1.Да 0.Нет");
      string a = Console.ReadLine();
      Console.WriteLine("Малые символы 1.Да 0.Нет");
      string b = Console.ReadLine();
      Console.WriteLine("Числа 1.Да 0.Нет");
      string c = Console.ReadLine();

      string result = a + b + c;
      

      switch(result) {
        case "111": 
        Console.WriteLine("Сгенерированный пароль");
        for (int j=1;j<=i;j++) {
  char[]array="0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();

    Random rnd = new Random();
    Console.Write(array[rnd.Next(0, array.Length-1)]);}
    break;
          
        case "110":
        Console.WriteLine("Сгенерированный пароль");
        for (int j=1;j<=i;j++) {
  char[]array="ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
    Random rnd = new Random();
    Console.Write(array[rnd.Next(0, array.Length-1)]);}
    break;
          
        case "100":
        Console.WriteLine("Сгенерированный пароль");
        for (int j=1;j<=i;j++) {
  char[]array="ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
    Random rnd = new Random();
    Console.Write(array[rnd.Next(0, array.Length-1)]);}
    break;

        case "011":
        Console.WriteLine("Сгенерированный пароль");
        for (int j=1;j<=i;j++) {
  char[]array="0123456789abcdefghijklmnopqrstuvwxyz".ToCharArray();
    Random rnd = new Random();
    Console.Write(array[rnd.Next(0, array.Length-1)]);}
    break;

          case "001":
        Console.WriteLine("Сгенерированный пароль");
        for (int j=1;j<=i;j++) {
  char[]array="0123456789".ToCharArray();
    Random rnd = new Random();
    Console.Write(array[rnd.Next(0, array.Length-1)]);}
    break;

        default:
        Console.WriteLine("Ошибка! Недостаточно данных для отображения");
        Console.WriteLine("Попробуйте снова");
          break;
      }

    Console.ReadLine();
      Console.Clear();
}
     }
}