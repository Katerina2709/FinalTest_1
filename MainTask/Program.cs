// Задача:
// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциям.

// Примеры:
// ["hello", "2", "world", "-)"] -> ["2", "-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ['Russia", "Denmark", "Kazan"] -> []

// ввод данных с консоли
int ConsoleInputInt (string message)
{
    Console.Write(message);
    int amount = Convert.ToInt32(Console.ReadLine());
    return amount;
}

string [] ConsoleInputStrArr (int count)
{
  string[] array = new string [count]; 
  for (int i = 0; i < count; i++)
  {
    Console.Write($"Введите {i + 1} элемент массива: ");
    array [i] = Console.ReadLine();
  }  
  return array;
}

int elements = ConsoleInputInt ("Введите количество элементов массива: ");
if (elements <= 0 )
{
    Console.Write("Ввели неверную длину массива");
}
else
{
    string[] ArrayStart = ConsoleInputStrArr (elements);
    string[] ArrayFinal = new string [0];
    for (int i = 0, k = 0; i < ArrayStart.Length; i++)
    {
        if(ArrayStart[i].Length <= 3)
        {
           Array.Resize (ref ArrayFinal, ArrayFinal.Length + 1);
           ArrayFinal [k] = ArrayStart[i];
           k++;
        }
    }

    Console.WriteLine ($"[\"{string.Join ("\", \"", ArrayStart)}\"] -> [\"{string.Join ("\", \"", ArrayFinal)}\"]");
}







