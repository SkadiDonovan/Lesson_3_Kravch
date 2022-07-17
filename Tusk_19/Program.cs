/*
Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
*/
void conclusion(bool res){
    if (res) Console.WriteLine("Введеное число палиндром ");
    else Console.WriteLine("Введеное число не палиндром ");
}

int num;
do
{
    Console.WriteLine("Введите пятизначное ");
    num = int.Parse(Console.ReadLine());
} while (num > 99999 || num < 10000);

bool result = false;

if ((num / 10000) == (num % 10)){
    result = true;
}
if ((num / 1000) == (num / 10)){
    result = true;
}

conclusion(result);



