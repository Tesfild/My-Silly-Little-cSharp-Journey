using System; 

class URI {

    static void Main(string[] args) { 

        string[] valores = Console.ReadLine().Split(' ');
        
        int codigo = int.Parse(valores[0]);
        int quantidade = int.Parse(valores[1]);

        double total = 0;

        switch (codigo) {
            case 1:
                total = quantidade * 4.0;
                break;
            case 2:
                total = quantidade * 4.5;
                break;
            case 3:
                total = quantidade * 5.0;
                break;
            case 4:
                total = quantidade * 2.0;
                break;
            case 5:
                total = quantidade * 1.5;
                break;
            default:
                break;
        }
        
        Console.WriteLine($"Total: R$ {total:F2}");
    }

}