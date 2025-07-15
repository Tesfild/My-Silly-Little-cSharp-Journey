using System; 

class URI {

    static void Main(string[] args) { 

        double valor = double.Parse(Console.ReadLine());
        
        int[] notas = {100, 50, 20, 10, 5, 2};
        double[] moedas = {1, 0.50, 0.25, 0.10, 0.05, 0.01};
        int[] moedasCentavos = { 100, 50, 25, 10, 5, 1 };
        
        int valorInteiro = (int)valor; 
        int valorMoedas = (int)Math.Round((valor - valorInteiro) * 100);
        
        Console.WriteLine("NOTAS:");
        foreach(int nota in notas) {
            
            int quantidadeNotas = valorInteiro / nota;
            valorInteiro %= nota;
            Console.WriteLine($"{quantidadeNotas} nota(s) de R$ {nota}.00");
        }
        
        valorMoedas += valorInteiro * 100;
        
        Console.WriteLine("MOEDAS:");
        foreach(int moeda in moedasCentavos) {
            
            int quantidadeMoedas = valorMoedas / moeda;
            valorMoedas %= moeda;
            Console.WriteLine($"{quantidadeMoedas} moeda(s) de R$ {(moeda / 100.0):0.00}");
        }
        
    }

}