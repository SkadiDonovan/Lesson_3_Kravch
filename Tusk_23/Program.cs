/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
*/
void getCubes(int num)
{
    for (int i = 1; i <= num; i++){
        Console.WriteLine(i*i*i);
    }
}

Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine());
getCubes(num);