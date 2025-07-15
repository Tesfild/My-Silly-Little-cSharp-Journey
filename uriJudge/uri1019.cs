using System; 

class URI {

    static void Main(string[] args) { 

       int N = int.Parse(Console.ReadLine());
       
       int resto = N % 3600;
       
       int hora = N / 3600;
       int minuto = resto / 60;
       int segundo = resto % 60;
       
       Console.WriteLine($"{hora}:{minuto}:{segundo}");

    }

}