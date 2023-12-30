/*Задайте произвольный массив. Выведете его элементы, начиная с конца. 
Использовать рекурсию, не использовать циклы.*/

void FillPrintArray(int[] array, int index = 0)//метод для создания и печати массива
{
	if (index < array.Length)
	{
		
		array[index] = new Random().Next(1, 10);
		Console.Write(array[index] + " ");
		FillPrintArray(array, index + 1);
	}
}

void ReversArray(int[] array, int index)
{
	if (index >= 0)
	{
		Console.Write(array[index] + " ");
		ReversArray(array, index - 1);
	}	
}
int[] array = new int[5];
FillPrintArray(array);
Console.WriteLine();
ReversArray(array, array.Length - 1);