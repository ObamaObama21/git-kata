static int ReturnNumbers(int a, int b)
{
    int multiply = a * b;

    return multiply;
}

static void Main()
{
    int a = 4;
    int b = 5;
    int result = ReturnNumbers(a, b);
    Console.WriteLine(result);
}

Main();