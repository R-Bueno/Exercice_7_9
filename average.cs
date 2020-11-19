/*This program calculates marks' average, this marks are set by user entering
 * them till user types end.
*/

using System;

public class Average
{
    public static void Main()
    {
        double sumOfMarks = 0, individualMark, count = 0, average;
        string mark;
        
        Console.Write("Insert a mark: ");
        mark = Console.ReadLine(); 
        
        while(mark != "end")
        {  
            individualMark = Convert.ToDouble(mark);
            
            count++;
            
            sumOfMarks += individualMark;
            
            Console.Write("Insert a mark: ");
            mark = Console.ReadLine();
        }
        
        if(count != 0)
        {
            average = sumOfMarks / count;  
            
            Console.WriteLine("The average is {0}.", average);
        }
    }
}
