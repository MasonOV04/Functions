Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
void  Number(int a, int b) {
    int start = 1;
    for (int i = 0; i<b; i++) {
        start = start * a;
    }
     Console.WriteLine($"А в стпени В равно: {start}");
}
Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());
Number(a,b);
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// void Number (int a) {
//     int sum = 0;
//     while(a>0){
//         int num =  a % 10;
//         a=a/10;
        
//         sum = sum + num;
//     }
//     Console.WriteLine($"Сумма цифр в числе равна: {sum}");
// }
// Console.WriteLine("Введите число a");
// int a = Convert.ToInt32(Console.ReadLine());
// Number(a);
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
