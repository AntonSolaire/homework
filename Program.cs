// Задача 1

// Console.WriteLine("Введите первое число");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if(firstNumber>secondNumber) {
//     Console.WriteLine($"{firstNumber} больше, {secondNumber} меньше "); 
// }
// else {
//     Console.WriteLine($"{secondNumber} больше, {firstNumber} меньше"); 
// }

//Задача 2

// Console.WriteLine("Введите первое число");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число");
// int thirdNumber = Convert.ToInt32(Console.ReadLine());

// int max = firstNumber;

// if(secondNumber>max) {
//     max = secondNumber;
// }

// if(thirdNumber>max) {
//     max = thirdNumber;
// }
// Console.WriteLine(max);

//Задача 3

// Console.WriteLine("Введите число");
// int Number = Convert.ToInt32(Console.ReadLine());

// if (Number % 2 == 0) {
//     Console.WriteLine("Число чётное");
// }
// else {
//     Console.WriteLine("Число нечётное");
// }

// Задача 4

Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());

int res = Number;
Number = 0;

while( (res-1) > Number){
    Number = Number + 2;
    Console.Write(Number);
}








