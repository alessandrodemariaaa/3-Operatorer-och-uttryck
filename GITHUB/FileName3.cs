﻿/*
 * 4.   Skriv ett uttryck som kontrollerar ett givet heltal för att se om dess 
 *      tredje värdesiffra (dvs tredje siffran från höger) är 7. 
 *      Till exempel 1732 -> true.
*/

Console.Write("Ange ett heltal (större än 99): ");
int number = int.Parse(Console.ReadLine());

bool isSeven;
number = number / 100;
isSeven = number % 10 == 7;

Console.WriteLine($"Tredje siffran i {number} är 7: {isSeven}");