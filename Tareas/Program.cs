// See https://aka.ms/new-console-template for more information
// SEMANA 2 TIPOS DE DATOS PRIMITIVOS
// crear dos clases en C# para representar un círculo y un cuadrado. Cada clase encapsula sus propiedades y proporciona métodos para calcular el área y el perímetro.
using System;

public class Circulo
{
    // Propiedad para el radio del círculo
    public double Radio { get; set; }

    // Constructor
    public Circulo(double radio)
    {
        Radio = radio;
    }

    // Método para calcular el área
    public double CalcularArea()
    {
        return Math.PI * Math.Pow(Radio, 2);
    }

    // Método para calcular el perímetro
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * Radio;
    }
}

public class Cuadrado
{
    // Propiedad para el lado del cuadrado
    public double Lado { get; set; }

    // Constructor
    public Cuadrado(double lado)
    {
        Lado = lado;
    }

    // Método para calcular el área
    public double CalcularArea()
    {
        return Math.Pow(Lado, 2);
    }

    // Método para calcular el perímetro
    public double CalcularPerimetro()
    {
        return 4 * Lado;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear un círculo con radio 5
        Circulo circulo = new Circulo(5);
        Console.WriteLine($"Área del círculo: {circulo.CalcularArea()}");
        Console.WriteLine($"Perímetro del círculo: {circulo.CalcularPerimetro()}");

        // Crear un cuadrado con lado 4
        Cuadrado cuadrado = new Cuadrado(4);
        Console.WriteLine($"Área del cuadrado: {cuadrado.CalcularArea()}");
        Console.WriteLine($"Perímetro del cuadrado: {cuadrado.CalcularPerimetro()}");
    }
}

