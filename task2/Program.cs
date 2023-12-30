/*Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.*/
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

int AckermanFunction(int m, int n)
{
	if (m == 0)
	{
		return n+1;
	}
	if (n == 0)
	{
		return AckermanFunction(m - 1, n = 1);
	}
	return AckermanFunction(m-1, AckermanFunction (m, n-1));
	
}

int numberM = GetnumberM();
int numberN = GetnumberN();
int A = AckermanFunction(numberM, numberN);
Console.WriteLine(A);
