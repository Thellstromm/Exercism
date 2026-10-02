public static class LineUp
{
    public static string Format(string name, int number)
    {
        if (number % 10 == 1)
        {
            return $"{name}, you are the {number}st customer we serve today. Thank you!";
        }
        else if (number % 10 == 2)
        {
            return $"{name}, you are the {number}nd customer we serve today. Thank you!";
        }
        else if (number % 10 == 3)
        {
            return $"{name}, you are the {number}rd customer we serve today. Thank you!";
        }
        else
        {
            return $"{name}, you are the {number}th customer we serve today. Thank you!";
        }
    }
}