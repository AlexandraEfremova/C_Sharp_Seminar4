// Заполнить массив на N (вводится с консоли, не более 8) случайных целых чисел от 0 до 9
// Сформируйте целое число, которое будет состоять из цифр из массива. 
// Старший разряд числа находится на 0-м индексе, младший на последнем

void Main()
{
    int sizeOfArray = ReadInt("Введите размер массива: ");
    if(sizeOfArray < 1 || sizeOfArray > 9)
    {
        System.Console.WriteLine("Некорректные значения!");
        return;
        // в данном случае return эекстренно закрывает программу и она дальше работать не будет
    }
    int[] array = GenerateArray(sizeOfArray, 0, 9);
    PrintArray(array);

    System.Console.WriteLine(string.Join(", ", array));
    // System.Console.WriteLine(string.Concat(array));
    // System.Console.WriteLine(FromArrayToNumber(array));
}

int FromArrayToNumber(int[] array)
{
    int resultNumber = 0;
    foreach(int element in array)
    {
        resultNumber *= 10;
        resultNumber += element;
        // пример того как это будет
        // 1 2 3 4 5
        // resultNumber = 0 * 10 = 0
        // resultNumber = 0 + 1 = 1
        // следующая итерация
        // resultNumbert = 1 *10 = 10
        // resultNumber = 10 + 2 = 12 и т.д. ло конца массива
    }
    return resultNumber;
}


void PrintArray(int[] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        System.Console.Write(arrayForPrint[i] + " ");
    }
    System.Console.WriteLine();
}


int[] GenerateArray(int size, int minRange, int maxRange)
{
    int[] tempArray = new int[size];
    Random temp = new Random();
    for(int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = temp.Next(minRange, maxRange + 1);
    } 
    return tempArray;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();
