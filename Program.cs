Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int max = firstNumber;
int min = secondNumber;

if(firstNumber>secondNumber) {
    Console.WriteLine($"{firstNumber} больше"); 
}
else {
    Console.WriteLine($"{secondNumber} больше"); 
}
