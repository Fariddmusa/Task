int[] number = { 4, 35, 3, 5, 67, 8, 2 };
int maxnumber = number[0];
for(int i = 0; i < number.Length; i++)
{
    if (number[i] > maxnumber)
    {
        maxnumber = number[i];
    }
}
Console.WriteLine(maxnumber);