using System; 

class URI {

    static void Main(string[] args) { 

        string[] valores = Console.ReadLine().Split(' ');
        
        double A = double.Parse(valores[0]);
        double B = double.Parse(valores[1]);
        double C = double.Parse(valores[2]);
        
        if (A + B > C && A + C > B && B + C > A) {
            double perimetro = A + B + C;
            Console.WriteLine($"Perimetro = {perimetro:F1}");
        }
        else {
            double area = ((A + B) * C) / 2;
            Console.WriteLine($"Area = {area:F1}");
        }

    }

}