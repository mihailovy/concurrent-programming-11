using System;
using System.Threading;

// Клас с метод за изпълнение в нишка:
class MyClass {
  
   // Брой съобщения:
   private int count;
  
   // Интервал между съобщенията:
   private int time;
  
   // Текст за показване:
   private string text; 
  
   // Метод за изпълнение в нишка:
   public void show() {
      Console.WriteLine(text+": Начало...");
      for (int i = 1; i <= count; i++) {
         // Показване на съобщение:
         Console.WriteLine(text+" -> "+i);
         // Задържане изпълнението на нишката:
         Thread.Sleep(time);
      }
      Console.WriteLine(text+": Край...");
   }
  
   // Конструктор:
   public MyClass(int c, int t, string txt){
      count = c;
      time  = t;
      text  = txt;
   }
}

// Главен клас:
class ManyThreadsDemo{
  
   // Главен метод:
   static void Main() {
     
      Console.WriteLine("Главна нишка: Начало...");
    
      // Създаване на обекти:
      MyClass objA = new MyClass(5, 20000, "Нишка A");
      MyClass objB = new MyClass(6, 10000, "Нишка B");
      MyClass objC = new MyClass(8,  5000, "Нишка C");
     
      // Създаване на обекти на нишките:
      Thread A = new Thread(objA.show);
      Thread B = new Thread(objB.show);
      Thread C = new Thread(objC.show);
      
      // Стартиране на дъщерните нишки:
      A.Start();
      B.Start();
      C.Start();
      Console.WriteLine("Главна нишка: Край...");
   }
}
