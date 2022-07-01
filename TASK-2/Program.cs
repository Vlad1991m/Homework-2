string Third(int num)
{
    int result = 1;
    if(num < 100) return ("There is no third digit in your number");
    else
    {
        while ((num / 100) >= 10)
        {
        num /= 10;
        }
        result = num % 10;
        return ("Third digit: " + result);
    }
}
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Third(num));