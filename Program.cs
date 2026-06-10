using System;

long number = 1; // Start at 1

while (true)
{
    long steps = 0;   
    long a = number;  
    
    while (a != 1)
    {
        if (a % 2 == 0)
        {
            a = a / 2;
        }
        else
        {
            a = 3 * a + 1;
        }
        steps++;
    }
    
    // Print the original starting number and its steps
    Console.WriteLine($"Number: {number}, Steps: {steps}");
    
    number++; 
}