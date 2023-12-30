/*Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
Использовать рекурсию, не использовать циклы.*/
int GetnumberM()
{
	Console.WriteLine("Введите число M: ");
	int numberM = Convert.ToInt32(Console.ReadLine());
	return numberM;
}
int GetnumberN()
{
	Console.WriteLine("Введите число N: ");
	int numberN = Convert.ToInt32(Console.ReadLine());
	return numberN;
}
void ArrayNumber(int start, int number)
{
	if(start <= number)
	{
		Console.Write(start + " ");
		ArrayNumber(start + 1, number);
	}
}

int numberM = GetnumberM();
int numberN = GetnumberN();
ArrayNumber(numberM, numberN);