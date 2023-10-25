using System;

namespace project {
    
    class Program {
        
        static void Main() {

        byte number = 10;
        byte number2 = 20;


        if (number2 > number) {
            Console.Write("Biggest number , ");
            Console.Write(number2);
            Console.ReadKey();
        }

        else if(number == number2) {

            Console.WriteLine("all numbers are =");
            Console.ReadKey();

        }


        else {
            Console.WriteLine("wrong number (error)");
            Console.ReadKey();
        }


        }

    }

}
