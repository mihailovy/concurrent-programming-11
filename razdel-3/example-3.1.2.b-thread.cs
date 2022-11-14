using System;
using System.Threading;

public class ThreadExample {
  
    // Този метод-делгат се пуска, когато се извика нишката.  
    // Методът реализира цикъл от 0 до 9. Изходът се подава към конзолата.
    public static void ThreadProc() {
        for (int i = 0; i < 100; i++) {
            Console.WriteLine("Втора нишка: {0}", i);
            // Yield the rest of the time slice.
            // Thread.Sleep(50);
        }
    }

    public static void Main() {
        Console.WriteLine("Главна нишка: предстои да се стартвира втора нишка.");
        
        // Конструкторът на нишката изисква да се подаде делегат от тип ThreadStart,
        // който представлява метода, който ще се изпълнява на нишката. 
        // C# опростява създаването на този делегат. 
        Thread t = new Thread( new ThreadStart(ThreadProc) );

        for (int i = 0; i < 100; i++) {
            Console.WriteLine("Главна нишка: броим числа ... "+i+".");
            Thread.Sleep(0);
        }
        
        // ThreadProc се стартира. На еднопроцесорна машина, втората нишка не получава
        // никакво процесорно време, докато главната нишка не върне управлението. 
        // Ще разкоментираме реда t.Start(), за да се види разликата.
        t.Start();
        //Thread.Sleep(0);

        for (int i = 100; i < 201; i++) {
          Console.WriteLine("Главна нишка: броим числа ... "+i+".");
           Thread.Sleep(50);
        }

        Console.WriteLine("Главна нишка: извиква Join(), за да изчака края на ThreadProc.");
        t.Join();
        Console.WriteLine("Главна нишка: ThreadProc.Join се връща.");
        Console.ReadLine();
    }
}
