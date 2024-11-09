using System;

class Program{

    static void Main(string [] arg){

        Console.Write("Enter a number to find its Multiplication : ");
        int numb = Convert.ToInt32(Console.ReadLine());

        for(int i = 1; i < 13; i++){
            Console.WriteLine(numb * i);
        }

    }
}