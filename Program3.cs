int point = 0;
if (point > 100 || point < 0)
{
    Console.WriteLine("point must be between 0 and 100");
}
else if (point >= 91 && point <= 100)
{
    Console.WriteLine("point: A");
}
else if (point >= 81 && point <= 90)
{
    Console.WriteLine("point: B");
}
else if (point >= 71 && point <= 80)
{
    Console.WriteLine("point: C");
}
else if (point >= 61 && point <= 70)
{
    Console.WriteLine("point: D");
}
else if (point >= 51 && point <= 60)
{
    Console.WriteLine("point: E");
}