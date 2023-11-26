using MVVMConsoleExample;

class Program
{
    static void Main(string[] args)
    {
        var viewModel = new MainViewModel();

        Console.WriteLine("Ingrese el Valor1:");
        viewModel.Valor1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el Valor2:");
        viewModel.Valor2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el Valor3:");
        viewModel.Valor3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Suma: {viewModel.Suma}");
        Console.WriteLine($"Producto: {viewModel.Producto}");
    }
}