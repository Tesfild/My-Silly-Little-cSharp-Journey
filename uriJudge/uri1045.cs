using System; 

class URI {

    static void Main(string[] args) { 

       string[] valor = Console.ReadLine().Split(' ');
       
       double A = double.Parse(valor[0]);
       double B = double.Parse(valor[1]);
       double C = double.Parse(valor[2]);
       
       double[] lados = { A, B, C };
       
        Array.Sort(lados);
        Array.Reverse(lados);
        A = lados[0];
        B = lados[1];
        C = lados[2];
       
       if ((A >= (B+C))) {
           Console.WriteLine("NAO FORMA TRIANGULO");
       }
       else if (Math.Pow(A, 2) == (Math.Pow(B, 2) + Math.Pow(C, 2))) {
           Console.WriteLine("TRIANGULO RETANGULO");
       }
       else if (Math.Pow(A, 2) > Math.Pow(B, 2) + Math.Pow(C, 2)) {
           Console.WriteLine("TRIANGULO OBTUSANGULO");
       }
       else if (Math.Pow(A, 2) < Math.Pow(B, 2) + (Math.Pow(C, 2))) {
           Console.WriteLine("TRIANGULO ACUTANGULO");
       }
       
       if ((A == B) && (B == C)) {
           Console.WriteLine("TRIANGULO EQUILATERO");
       }
       else if ((A == B) || (A == C) || (B == C)) {
           Console.WriteLine("TRIANGULO ISOSCELES");
       }
    }
}