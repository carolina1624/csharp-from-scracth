// Top-level statements (puedes pegar esto directamente en Program.cs)
var circ = new Circulo();
circ.Radio = 20;
var result_area = circ.Area();
var result_perim = circ.Perimetro();

Console.WriteLine($"El área es: {result_area} y el perímetro es: {result_perim} el nuevo radio es : {circ.Add10()}");

int prev = 0, next = 1, sum;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(prev);
    sum = prev + next;
    prev = next;
    next = sum;
}

Console.WriteLine("Número a dividir:");
if (!double.TryParse(Console.ReadLine(), out double n))
{
    Console.WriteLine("Entrada inválida para el número.");
}
else
{
    Console.WriteLine("Divisor:");
    if (!double.TryParse(Console.ReadLine(), out double divisor))
    {
        Console.WriteLine("Entrada inválida para el divisor.");
    }
    else
    {
        try
        {
            if (divisor == 0)
                throw new DivideByZeroException();

            Console.WriteLine($"Resultado: {n / divisor}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("No se puede dividir por cero!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error desconocido: {ex.Message}");
        }
    }
}

// Clases al final
abstract class Figura
{
    public abstract double Area();
    public abstract double Perimetro();
}

interface IExtraCalculations
{
    double Add10();
}

class Circulo : Figura, IExtraCalculations
{
    public double Radio { get; set; }

    public override double Area() => Math.PI * Radio * Radio;
    public override double Perimetro() => 2 * Math.PI * Radio;

    public double Add10() => Radio + 10;
}





    
