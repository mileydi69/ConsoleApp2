using System;

// Clase que representa un círculo
public class Circulo
{
    // Campo que almacena el radio del círculo
    private double radio;

    // Constructor que inicializa el radio del círculo
    public Circulo(double radio)
    {
        this.radio = radio;
    }

    // Método que calcula el área del círculo
    public double CalcularArea()
    {
        // Formula: π * radio^2
        return Math.PI * radio * radio;
    }

    // Método que calcula el perímetro del círculo
    public double CalcularPerimetro()
    {
        // Formula: 2 * π * radio
        return 2 * Math.PI * radio;
    }
}

// Clase que representa un triángulo
public class Triangulo
{
    // Campos que almacenan las longitudes de los lados del triángulo
    private double ladoA;
    private double ladoB;
    private double ladoC;

    // Constructor que inicializa los lados del triángulo
    public Triangulo(double ladoA, double ladoB, double ladoC)
    {
        this.ladoA = ladoA;
        this.ladoB = ladoB;
        this.ladoC = ladoC;
    }

    // Método que calcula el área del triángulo utilizando la fórmula de Herón
    public double CalcularArea()
    {
        // Semiperímetro: (ladoA + ladoB + ladoC) / 2
        double semiperimetro = (ladoA + ladoB + ladoC) / 2;
        // Formula: √(s * (s - ladoA) * (s - ladoB) * (s - ladoC))
        return Math.Sqrt(semiperimetro * (semiperimetro - ladoA) * (semiperimetro - ladoB) * (semiperimetro - ladoC));
    }

    // Método que calcula el perímetro del triángulo
    public double CalcularPerimetro()
    {
        // Formula: ladoA + ladoB + ladoC
        return ladoA + ladoB + ladoC;
    }
}

// Ejemplo de uso
class Program
{
    static void Main(string[] args)
    {
        // Crear un círculo con radio 5
        Circulo circulo = new Circulo(5);
        Console.WriteLine($"Área del círculo: {circulo.CalcularArea()}");
        Console.WriteLine($"Perímetro del círculo: {circulo.CalcularPerimetro()}");

        // Crear un triángulo con lados 3, 4 y 5
        Triangulo triangulo = new Triangulo(3, 4, 5);
        Console.WriteLine($"Área del triángulo: {triangulo.CalcularArea()}");
        Console.WriteLine($"Perímetro del triángulo: {triangulo.CalcularPerimetro()}");
    }
}