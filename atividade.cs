using System;

public abstract class Veiculo
{
    protected double TaxaDiaria { get; }

    public Veiculo(double taxaDiaria)
    {
        TaxaDiaria = taxaDiaria;
    }

    public abstract double CalcularValorTotal(int numDiarias);
}

public class Carro : Veiculo
{
    public Carro() : base(50) // Fixed daily rate for a car
    {
    }

    public override double CalcularValorTotal(int numDiarias)
    {
        return numDiarias * TaxaDiaria;
    }
}

public class Moto : Veiculo
{
    public Moto() : base(25) // Fixed daily rate for a motorcycle
    {
    }

    public override double CalcularValorTotal(int numDiarias)
    {
        return numDiarias * TaxaDiaria;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Carro carro = new Carro();
        Moto moto = new Moto();

        int numDiarias = 10;

        double valorTotalCarro = carro.CalcularValorTotal(numDiarias);
        double valorTotalMoto = moto.CalcularValorTotal(numDiarias);

        Console.WriteLine("Total value for 10 days of car rental: " + valorTotalCarro + " reais");
        Console.WriteLine("Total value for 10 days of motorcycle rental: " + valorTotalMoto + " reais");
    }
}
