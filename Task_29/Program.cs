// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void lenArray(int [] number )
{
 for (int i = 0; i < number.Length; i++)
{
    number[i] = new Random().Next(1 , 99);
}
}    
void Array(int[] number )
{
for (int i = 0; i < number.Length; i++)
{
    Console.Write(number[i] + " ");  
}
}
int size = 8;
int [] numbers =  new int [size];
lenArray(numbers);
Array(numbers);
