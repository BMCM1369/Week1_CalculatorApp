// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("Please enter the first number");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter the second number");
int SecondNumber = Convert.ToInt32(Console.ReadLine());

int result = FirstNumber + SecondNumber;

Console.WriteLine("Adding {0} and {1} gives the answer {2}", FirstNumber, SecondNumber, result);