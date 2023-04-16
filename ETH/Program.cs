// Parsa Ebrahimi - shamsipoor
using ETH;

class Program
{
    static async Task Main(string[] args)
    {
        bool continueProgram = true;
        while (continueProgram)
        {
            Console.WriteLine("Please enter your crypto currency to calculate . (Example : BTC-USDT , ETH-USDT , LTC-USDT , APE-USDT , ... ) ");

            string symbol = Console.ReadLine().ToUpper();

            KuCoin calculator = new KuCoin(symbol);
            decimal averagePrice = await calculator.CalculateAveragePrice();
            decimal lastPrice = calculator.GetLastPrice();

            Console.WriteLine($"{symbol} price for the next 24 Hour: ${averagePrice}");

            decimal percentageError = PricePercentageError.Calculate(lastPrice, averagePrice);
            Console.WriteLine($"Percentage error between current price and target price: {percentageError}%");

            Console.WriteLine();
            continueProgram = YesNoQuestion.Ask("Do you want to continue the program?");
            Console.WriteLine();
        }
    }
}


