// программа, которая из имеющегося массива строк формирует массив из строк, длина которых меньше
// или равна 3 символам. массив можно задать с клавиатуры, либо задать на старте выполнения алгоритма.

string [] LessThan4CharsArray(string[] array)
{
    int tempSize = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i].Length <= 3)
       {
        tempSize ++;
       } 
    }
// после первого цикла узнали количество 1-3 символьных строк в массиве
// теперь можно объявить пустой массив необходимой длины
    string[] resultArray = new string[tempSize];
    int tempCount = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length <= 3)
        {
           resultArray[tempCount] = array[j];
           tempCount++; 
        }
    }

    return resultArray;
}
void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {   
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}

// задали массив вручную
string[] array = {"se", "ewwef", "sfwetrt", "343", "dfsd", "ddfz", "ed", "r", "rf"}; 
// прогоняем массив
string[] array2 = LessThan4CharsArray(array);
// распечатываем результат
PrintArray(array2);