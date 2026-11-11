int score = 82;
string grade = score switch
{
    >= 90 => "A",
    >= 80 => "B",
    >= 70 => "C",
    _ => "Needs practice"
};

Console.WriteLine($"Score {score}: {grade}");

for (int number = 1; number <= 5; number++)
{
    Console.WriteLine(number);
}
