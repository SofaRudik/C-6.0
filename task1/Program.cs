Console.Clear();
Console.WriteLine("Введите число ");
int n= Convert.ToInt32(Console.ReadLine());
int [] array= new int [n];
InputArray(array);
Console.WriteLine($"Начальный массив чисел: [{string.Join(",",array)}]");
Console.WriteLine(ReverseArray(array));

void InputArray (int[]array)
{
    for (int i=0; i<array.Length; i++)
    array[i]=new Random().Next(-10,11);
}

int ReverseArray (int[]array)
{
    int count=0;
    for (int i=0; i<array.Length; i++)
    {if(array [i]>0) count ++;}
    return count;
} 