// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

Console.WriteLine("Ingresa el consumo :");
double consumo=double.Parse(Console.ReadLine());
double descuento = 0;

if (consumo <= 100)
{
    descuento = consumo * 0.10;

}
else
{
    descuento = consumo * 0.20;

}

double totalconsumo = consumo - descuento;
double impuesto = totalconsumo * 0.18;
double total = totalconsumo + impuesto;

Console.WriteLine("total descuento: " + totalconsumo+ " soles" );
Console.WriteLine("el impuesto es: " + impuesto+ " soles");
Console.WriteLine("esto es el total que pagara : "+total+ " soles");
