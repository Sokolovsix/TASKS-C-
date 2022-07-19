int randomNumber = new Random ().Next(99 , 1000);

int firstDigit = randomNumber / 100;
int secondDigit = randomNumber % 10;

Console.WriteLine($"{randomNumber} -> {firstDigit+""+secondDigit}");
