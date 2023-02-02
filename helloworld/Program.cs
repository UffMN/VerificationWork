
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

