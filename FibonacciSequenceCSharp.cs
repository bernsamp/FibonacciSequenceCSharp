    using System;

      public class FibonacciExample{

         public static void Main(string[] args){  
            
            int firstNumber = 0;
            int secondNumber = 1;
            int nextNumber;

            Console.Write("Enter the number of elements of the Fibonacci Sequence you want to see printed: ");

            int numberOfElements = int.Parse(Console.ReadLine());  

            Console.Write(firstNumber + " " + secondNumber + " ");

            for(int i=2; i<numberOfElements; ++i){    
              nextNumber = firstNumber + secondNumber;    
              Console.Write(nextNumber + " ");    
              firstNumber = secondNumber;    
              secondNumber = nextNumber;    
             }    
          }  
       }  