// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello, World!");

int a = 500;
//stringa di formato
Console.WriteLine("Primo={0}", a);
//interpolazione di sringhe 
Console.WriteLine($"primo={a}");

short b = 100;

Console.WriteLine("Secondo={0}", b);
Console.WriteLine($"secondo={b}");

sbyte c = -50;

Console.WriteLine("Terzo={0}", c);
Console.WriteLine($"terzo={c}");

long d = 1_000_000;

Console.WriteLine("Quarto={0}", d);
Console.WriteLine($"quarto={d}");


