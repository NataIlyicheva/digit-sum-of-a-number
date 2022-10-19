Console.WriteLine("Введите число: ");
string num = Console.ReadLine()!;
int len = num.Length;
int[] value = new int[len];
int count = 0;
int sum = 0;

while (count < len)
{
    value[count] = Convert.ToInt32(num[count].ToString());
    count++;
}
    for (count = 0; count < len; count++)
    sum += value[count];

Console.WriteLine(sum);