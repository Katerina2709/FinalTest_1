// Задача:
// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциям.

// Примеры:
// ["hello", "2", "world", "-)"] -> ["2", "-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ['Russia", "Denmark", "Kazan"] -> []

string[] ArrayStart = {"hello", "2", "world", "-)"};
string[] ArrayFinal = new string [2];
for (int i = 0, k = 0; i < ArrayStart.Length; i++)
{
    if(ArrayStart[i].Length <= 3)
    {
      ArrayFinal [k] = ArrayStart[i];
      k++;
    }
}

Console.WriteLine ($"[\"{string.Join ("\", \"", ArrayStart)}\"] -> [\"{string.Join ("\", \"", ArrayFinal)}\"]");
