// Задача:
// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциям.

// Примеры:
// ["hello", "2", "world", "-)"] -> ["2", "-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ['Russia", "Denmark", "Kazan"] -> []

// ввод длины массива с консоли
int ConsoleInputInt (string message)
{
    Console.Write(message);
    int amount = Convert.ToInt32(Console.ReadLine());
    return amount;
}

// ввод строкового массива с консоли
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

// основной метод - формирование итогового массива из элементов, длина которых не превышает 3 символов
string [] CreateNewArray (string [] array)
{
  string[] arrayResult = new string [0];
  for (int i = 0, k = 0; i < array.Length; i++)
  {
    if(array[i].Length <= 3)
    {
        Array.Resize (ref arrayResult, arrayResult.Length + 1);
        arrayResult [k] = array[i];
        k++;
    }
  }
  return arrayResult;
}

// решение и вывод на консоль
int elements = ConsoleInputInt ("Введите количество элементов массива: ");
if (elements <= 0 )
{
  Console.Write("Ввели неверную длину массива");
}
else
{
  string[] ArrayStart = ConsoleInputStrArr (elements);
  string[] ArrayFinal = CreateNewArray (ArrayStart);
  Console.WriteLine ($"[\"{string.Join ("\", \"", ArrayStart)}\"] -> [\"{string.Join ("\", \"", ArrayFinal)}\"]");
}
// полное решение задачи