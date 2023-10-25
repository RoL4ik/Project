using System;

namespace project {
    
    class Program {
        
        static void Main() {

        byte number = 10;
        byte number2 = 20;


        if (number2 > number) {
            Console.Write("самое большое число, ");
            Console.Write(number2);
            Console.ReadKey();
        }

        else if(number == number2) {

            Console.WriteLine("Все чилса равны");
            Console.ReadKey();

        }


        else {
            Console.WriteLine("число не сходиться");
            Console.ReadKey();
        }


        }

    }

}