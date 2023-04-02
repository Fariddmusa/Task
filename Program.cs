int[] number = { 3, -4, 56, 7, -3, -66, 5 };
int positivecount = 0;
int negativecount = 0;
for(int i = 0; i < number.Length; i++)
{
    if (number[i] > 0)
    {
        positivecount++;
    }
    else if (number[i] < 0)
    {
        negativecount++;
    }
    
}
Console.WriteLine(positivecount);
Console.WriteLine(negativecount);