Console.WriteLine("Введите число: ");
string num = Console.ReadLine()!;
int size = num.Length;
int[] value = new int[size];
int count = 0;
int sum = 0;

while (count < size)
{
    value[count] = Convert.ToInt32(num[count].ToString());
    count++;
}
    for (count = 0; count < size; count++)
    sum += value[count];

Console.WriteLine(sum);
