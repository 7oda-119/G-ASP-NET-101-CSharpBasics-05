using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C_Basics05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Assignment04
            #region Question01
            ////Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print
            ////the second price(index 1).

            //double[] prices = [ 25.5, 40.0, 33.75 ];
            //Console.WriteLine(prices[1]);

            #endregion

            #region Question02
            //Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and shelf 1 has 1, 4 copies.
            //Print the number of copies on shelf 1, slot 0

            //int[,] shelfCopies = new int[2, 2]
            //{
            //    { 3, 5 },
            //    { 1, 4 }
            //};
            //Console.WriteLine(shelfCopies[1, 0]);

            #endregion

            #region Question03
            ////-Write a method called PrintWelcomeMessage that takes no parameters and
            ////prints "Welcome to the Library!".Call it from Main.

            //PrintWelcomeMessage();

            #endregion

            #region Question04
            ////Write a method PrintBookTitle(string title) that prints "Book title: " + title.
            ////Call it with "Clean Code".

            //PrintBookTitle("Clean Code");

            #endregion

            #region Question05
            ////Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable
            ////int pages = 400; and print pages afterward.
            ////What do you expect to see, and why?
            ////Answer: pages is passed by value (take a copy of the value of pages), so the original variable still has the same value of 400.

            //int pages = 400;
            //AddBonusPages(pages);
            //Console.WriteLine(pages);
            #endregion

            #region Question06
            ////Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0].
            ////Call it with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.
            ////What do you expect to see, and why?
            ////Answer: prices[] is passed by reference (take a copy of the reference of the original array),
            ////  so if we change the value of prices[0] in the method, it will also change the value of prices[0] in the original array.

            //double[] prices = { 25.5, 40.0 };
            //ApplyDiscount(prices);
            //Console.WriteLine(prices[0]);
            #endregion
            #endregion
        }
        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }

        static void PrintBookTitle(string title)
        {
            Console.WriteLine($"Book title: {title}");
        }
        static void AddBonusPages(int pages) 
        {
            pages += 50;
        }
        static void ApplyDiscount(double[] prices) 
        {
            prices[0] -= 5;
        }

    }
}
