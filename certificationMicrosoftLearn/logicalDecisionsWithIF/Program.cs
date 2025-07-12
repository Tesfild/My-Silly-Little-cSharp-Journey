using System;

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Rolls: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3)) {
   
    if ((roll1 == roll2) && (roll2 == roll3)) { 
        Console.WriteLine("Triples! Omg! +6 bonus to total!");
        total += 6;
   }
   else {
        Console.WriteLine("Doubles! So lucky! +2 bonus to total!");
        total += 2;
    }
}


if (total >= 16) {
    Console.WriteLine($"You Win a new car! Total: {total}");
}
else if (total >= 10) {
    Console.WriteLine($"You win a new laptop! Total: {total}");
}
else if (total == 7) {
    Console.WriteLine($"You win a trip for two! Total: {total}");
}
else {
    Console.WriteLine($"You Win a kitten! Total: {total}");
}
