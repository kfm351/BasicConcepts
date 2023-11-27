// 1 ЗАДАНИЕ 

Console.Write("Введите размерность квадратной матрицы: ");
// Ввод размера матрицы
int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[n, n];

Console.WriteLine("\nЗаполните матрицу:");

// Ввод элементов матрицы
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("");

// Вывод элементов матрицы
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

// Вызов функции для проверки симметричности матрицы и вывод результата
if (IsMatrixSymmetric(matrix))
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}

// Функция для проверки симметричности матрицы относительно главной диагонали
bool IsMatrixSymmetric(int[,] matrix)
{

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (matrix[i, j] != matrix[j, i])  // Проверяем элементы относительно главной диагонали
            {
                return false;  // Если элементы не симметричны, возвращаем false
            }
        }
    }
    return true;  // Если все элементы симметричны, возвращаем true
}

//---------------------------------------------------------------------------------------

// 2 ЗАДАНИЕ

//Console.Write("Введите количество элементов массива от 1 до 100: ");

//int elCount = Convert.ToInt32(Console.ReadLine());

//while (elCount < 1 || elCount > 100)
//{
//    Console.Write("\nОшибка! Введите количество элементов массива от 1 до 100: ");
//    elCount = Convert.ToInt32(Console.ReadLine());
//}

//Console.WriteLine("");

//int[] arr = new int[elCount];

//for (int i = 0; i < arr.Length; i++)
//{
//    Console.Write($"Введите элемент массива с индексом {i}:\t");
//    arr[i] = int.Parse(Console.ReadLine());
//}


//for (int i = 0; i < elCount; i++)
//{
//    if (arr[i] != 0)
//    {
//        for (int j = i + 1; j < elCount; j++)
//        {
//            if (arr[j] != 0 && arr[i] == -arr[j])
//            {
//                Console.WriteLine($"\nИндексы противоположных чисел: {i}, {j}");
//                return;
//            }
//        }
//    }
//}

//---------------------------------------------------------------------------------------

// 3 ЗАДАНИЕ

//Console.Write("Ведите сколько дней вы измеряли температуру: ");

//int n = Convert.ToInt32(Console.ReadLine());

//int[] tempt = new int[n];

//for (int i = 1; i < n + 1; i++)
//{
//    Console.Write("Ведите данные" + " " + i + "-го дня: ");
//    tempt[i - 1] = Convert.ToInt32(Console.ReadLine());
//}

//Console.WriteLine("\nВывод данных:");

//for (int i = 0; i < tempt.Length; i++)
//{
//    Console.WriteLine($"День {i + 1}: {tempt[i]}");
//}

//int max = 0;
//int min = 1000000000;

//int max1 = 0;
//int min1 = 0;
//int day1 = 0;
//int day2 = 0;

//for (int i = 0; i < tempt.Length; i++)
//{
//    if (tempt[i] > max)
//    {
//        max = tempt[i];
//        max1 = max;
//        day1 = i + 1;
//    }

//    if (tempt[i] < min)
//    {
//        min = tempt[i];
//        min1 = min;
//        day2 = i + 1;
//    }
//}

//Console.WriteLine($"\nДень {day2}: {min1} min");
//Console.WriteLine($"День {day1}: {max1} max");