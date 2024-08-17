// Задайте одномерный массив, заполненный случайными
//  числами. Определите количество простых чисел в этом массиве.

void Main()
{
    int sizeOfArray = ReadInt("Введите размер массива: ");
    if(sizeOfArray < 1)
    {
        System.Console.WriteLine("Некорректные значения!");
        return;
    }
    int[] array = GenerateArray(sizeOfArray, 0, 999);
    PrintArray(array);

    System.Console.WriteLine(CountPrimal(array));
}
// Создаём метод, который будет подсчитывать количество простых чисел в массиве
int CountPrimal(int[] array)
{
    int count = 0;

    foreach(int number in array)
    {
        // в данном примере мы будем обращаться к методу с проверкой на просое число
        // и проверять каждое число массива и если число будет просты, то мы будем
        // увеличивать счётчик count на 1
        if(isPrimal(number))
            count++;
    }
    return count;
}
// создаём метод с будевым типом значения, который будет отвечать на вопрос простое ли число
bool isPrimal(int number)
{
    // не имеет смысла проверять числа меньше 2
    if(number < 2)
        return false;

// то есть в данном случае мы будем делить число на цифры от 2 до квадрата этого числа
    for(int i = i = 2; i <= Math.Sqrt(number); i++)
    // если число поделится на какое-то число без остатка - это будет значить, что оно не простое,
    // то есть нам будет возвращаться false
        if(number % i == 0)
            return false;
    // если число прошло проверку, и не поделилось ни на одно из чисел без остатка, то 
    // нам вернётся true, то есть число простое
    return true;

}


void PrintArray(int[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
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
