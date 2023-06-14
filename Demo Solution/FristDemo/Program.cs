// See https://aka.ms/new-console-template for more information
using FristDemo;
using System.Globalization;


Console.WriteLine("Welcome to the Calculator");

Console.WriteLine("Please enter first number");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter second number");
int b = int.Parse(Console.ReadLine());

CalculatorClass c = new CalculatorClass();
c.Add(a, b);

Console.ReadLine();