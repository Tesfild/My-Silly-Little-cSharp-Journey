using System; 

class URI {

    static void Main(string[] args) { 

      int timeSpent = int.Parse(Console.ReadLine());
      int averageSpeed = int.Parse(Console.ReadLine());
      
      double calc = (timeSpent * averageSpeed) / 12.0;
      
      Console.WriteLine($"{calc:F3}");

    }

}