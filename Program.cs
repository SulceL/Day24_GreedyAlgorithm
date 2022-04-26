

Console.WriteLine("Please enter the price of a product!");
double Price = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter the amount of money you pay for the product!");
double Money = Convert.ToDouble(Console.ReadLine());


Console.WriteLine($"The product costs {Price} euros");
Console.WriteLine($"You gave me {Money} euros");





double[] coins = { 2, 1, 0.50, 0.10, 0.05, 0.02, 0.01, };
    int count, i;
double amount1 = (Money) - (Price);
Console.WriteLine("==========================");
if (amount1 < 0)
    Console.WriteLine("You donn't have enough money to by this product");
else
{
    for (i = 0; i < coins.Length; i++)
    {
        count = (int)(amount1 / coins[i]);


        if (count != 0)
            if (coins[i] == 2 || coins[i] == 1)
                Console.WriteLine("Count of {0} euros : {1}", coins[i], count);
            else
                Console.WriteLine("Count of {0} cents : {1}", coins[i]*100, count);
        amount1 %= Math.Abs(coins[i]);
    }
}


