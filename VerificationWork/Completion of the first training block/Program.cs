string[] arrayString;
string[] arrayLength3;
int count = 0;
int temp = 0;
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
arrayString = new string[n];

for(int i = 0; i < n; i++)
{
Console.Write($"Введите {i + 1} элемент: ");
arrayString[i] = Console.ReadLine();
if(arrayString[i].Length <= 3) count++;
}
arrayLength3 = new string[count];

Console.WriteLine($"Начальный массив: [{string.Join(", ", arrayString)}]");

for(int i = 0; i < n; i++)
{
if(arrayString[i].Length <= 3) 
{
    arrayLength3[temp] = arrayString[i];
    temp++;
}
}
Console.WriteLine($"Массив из элементов из 3 и меньше символов: [{string.Join(", ",arrayLength3)}]");