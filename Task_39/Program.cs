// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
//а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]


Задча решена не до конца



int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[] GetRandomArray(int length, int leftRange, int rightRange)
{

    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange + 1);
    }

    return array;
}