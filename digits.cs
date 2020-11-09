/*This program asks user to insert numbers till he tipes end, then, 
 * it calculates the amount of numbers with 1 digit, 2 digits, 3 digits 
 * or 4+ digits tiped.*/

using System;

class Digits
{
     static void Main()
     {
         int oneDigit = 0, twoDigits = 0, threeDigits = 0, moreThanThreeDigits = 0;
          
          Console.Write("Insert a number: ");
          string number = Console.ReadLine();
         
         while(number != "end")
         {
            int input = Convert.ToInt32(number);
            
            if(input != 0)
            {
                if(input/10 == 0)
                   oneDigit++;
                else 
                {
                    if (input/100 == 0)
                        twoDigits++;
                    else
                    {
                        if (input/1000 == 0)
                            threeDigits++;
                        else
                            moreThanThreeDigits++;
                    }
                }
            }
            
            number = Console.ReadLine();
        }

        Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", 
            oneDigit, twoDigits, threeDigits, moreThanThreeDigits); 
    }
}

