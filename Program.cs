int InputInt (string massage)
{
    Console.WriteLine(massage);
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}
int PolindromChek (int num)
{
    int rev =0;
    while (num>0)
    {
        rev = rev*10+num%10;
        num = num/10;
    }
    return rev;
}
int number = InputInt("Введите число");
int reverse = PolindromChek(number);
if (number == reverse)
{
    System.Console.WriteLine("Полиндром");
}
else
{
    System.Console.WriteLine("Не Полиндром");
}