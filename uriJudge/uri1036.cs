using System; 

class URI {

    static void Main(string[] args) { 

        string[] valores = Console.ReadLine().Split(' ');
        
        double A = double.Parse(valores[0]);
        double B = double.Parse(valores[1]);
        double C = double.Parse(valores[2]);
        
        double delta = Math.Pow(B, 2) - 4 * A * C;
        
        double B1 = (-B + Math.Sqrt(delta)) / (2 * A);
        double B2 = (-B - Math.Sqrt(delta)) / (2 * A);
        
        if (A == 0 || delta < 0) {
            Console.WriteLine("Impossivel calcular");
        }
        else {
            Console.WriteLine($"R1 = {B1:F5}");
            Console.WriteLine($"R2 = {B2:F5}");
        }
    }
}