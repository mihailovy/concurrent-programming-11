using System;
using System.Threading;
// Главен клас:
class JoinDemo{
    // Метод за дъщерна нишка:
   static void run(){
      Console.WriteLine("Дъщерната нишка е стартирана...");
      // Оператор за цикъл:
      for(int k=1;k<=5;k++){
         // Показване на съобщение:
         Console.WriteLine("Дъщерна нишка: "+k);
         // Задържане изпълнението на нишката:
         Thread.Sleep(2500);
      }
      Console.WriteLine("Дъщерната нишка приключи...");
   }
   // Главен метод:
   static void Main(){
      // Начално съобщение на главната нишка:
      Console.WriteLine("Главната нишка е стартирана...");
      // Обект на дъщерна нишка:
      Thread t=new Thread(run);
      // Стартиране на дъщерната нишка:
      t.Start();
      // Оператор за цикъл:
      for(char s='A';s<='F';s++){
         // Показване на съобщение:
         Console.WriteLine("Главна нишка: "+s);
         // Задържане изпълнението на нишката:
         Thread.Sleep(1000);
      }
      // Изчакване на дъщерната нишка да завърши:
      if(t.IsAlive) t.Join();
      // Последно съобщение на главната нишка:
      Console.WriteLine("Главната нишка приключи...");
   }
}
