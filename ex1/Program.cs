// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, -567, 89, 223-> 3

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

Console.Write("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] massive = new int[size];
int count = 0;
     for(int i = 0; i < size; i++)
        {
            Console.Write($"A[{i}] = ");
            massive[i] = Convert.ToInt32(Console.ReadLine());
            if (massive[i]>0)count=count+1;    
        }                  
Console.WriteLine();
PrintArray(massive);
Console.WriteLine();
if (count==0) Console.WriteLine ("Пользователь не ввел число больше 0");               
 else Console.WriteLine ($"Количество введенных полльзователем чисел больше 0 равно - {count}"); 
 


