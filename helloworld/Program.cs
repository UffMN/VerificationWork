
/*gcd(НОД) и lcm(НОК)
int GCDFinder (int firstNubmer, int secondNumber)
{
    int gcdnumber = 0;
    while (firstNubmer != secondNumber)
    {
        if (firstNubmer > secondNumber)
        firstNubmer = firstNubmer - secondNumber;
        else secondNumber = secondNumber - firstNubmer;
        gcdnumber = secondNumber;
    }
    return gcdnumber;
}
int ICMFinder (int firstNubmer, int secondNumber, int gcdnumber)
{
    int icmnumber = firstNubmer * secondNumber / gcdnumber;
    return icmnumber;
}

int n = 24;
int m = 44;

int gcd = GCDFinder(n,m);
int icm = ICMFinder(n,m,gcd);

Console.WriteLine($"gcd: {gcd}, lcm: {icm}");
*/

/* Maximum sum fmong the numbers
using System.Diagnostics;

int[] CreationArray (int sizelength)
{
int[] array = Enumerable.Range(1, sizelength)
                        .Select(item => Random.Shared.Next(10)) 
                        .ToArray();
//Console.WriteLine($"[{string.Join(", ", array)}]");
return array;
}

int MaximumSumAmongNumbersSlowversion (int[] array, int rangenumbers)
{
    
    int maximumsum = 0;
    for(int i = 0; i < array.Length - rangenumbers; i++)
    {
        int temp = 0;
        for(int j = i; j < i + rangenumbers; j++) temp += array[j];
        if (temp > maximumsum) maximumsum = temp;
    }
    return maximumsum;

}

int MaximumSumAmongNumbersFastversion (int[] array, int rangenumbers)
{
    
    int maximumsum = 0;
    for(int j = 0; j < rangenumbers; j++) maximumsum += array[j];
    int temp = maximumsum;
    for(int i = 1; i < array.Length - rangenumbers; i++)
    {
        temp = temp - array[i - 1] + array[i + (rangenumbers - 1)];
        if (temp > maximumsum) maximumsum = temp;
    }
    return maximumsum;

}

int size = 1000;
int range = 300;

int[] NewArray = CreationArray(size);

Stopwatch sloww = new();
sloww.Start();
int max = MaximumSumAmongNumbersSlowversion(NewArray, range);
Console.WriteLine(max);
sloww.Stop();
Console.WriteLine($"time = {sloww.ElapsedMilliseconds} ms");

Stopwatch fastw = new();
fastw.Start();
int max1 = MaximumSumAmongNumbersFastversion(NewArray, range);
Console.WriteLine(max1);
fastw.Stop();
Console.WriteLine($"time = {fastw.ElapsedMilliseconds} ms");
*/

//Big O Notation
/*
int[] array = new int[5];
for (int i = 0; i < 5; i++)
    array[i] = new Random().Next(1, 10);
Console.WriteLine(string.Join(" ", array));
Console.WriteLine(array[3]); //Algorithm complexity "0 notation" equal to 0(1) because we need one action to find out the result
// [4, 5, 3, 1, 2] it will take 5 operations to find out the sum of the array => 0(5)
// 0(n)
// [1, 2, 3, 4, 5] => 0(n * log n) - time of quicksort
// ((5 + 1) / 2) * 5 [the sum of the arithmetic progression] => 0(1)
// n < n * log(n) + 1*/

/*// 0(n^2)
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < n + 1; i++)
{
    for (int j = 1; j < n + 1; j++)
    {
        Console.Write($"{i * j}\t");
    }
    Console.WriteLine();
}

int[,] matrix = new int[n, n];
for (int i = 0; i < n; i++)
{
    for (int j = i; j < n; j++)
    {
        matrix[i, j] = (i + 1) * (j + 1);
        matrix[j, i] = (i + 1) * (j + 1);
    }
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{matrix[i, j]}\t");
    }
    Console.WriteLine();
}*/
