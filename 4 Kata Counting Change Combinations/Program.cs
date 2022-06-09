using System;

namespace _4_Kata_Counting_Change_Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money = 4;
            int[] coins = new int[] { 1, 2 };
            Console.WriteLine(Kata.CountCombinations(money,coins));

        }
    }

    public static class Kata
    {
        public static int CountCombinations(int money, int[] coins)
        {
            return Count(money, ref coins, coins.Length);
        }
        private static int Count(int money, ref int[] coins, int count)
        {
            if (money < 0 || count < 1 ) return 0;
            if (money == 0) return 1;
            return Count(money, ref coins, count - 1) + Count(money - coins[count - 1], ref coins, count);


        }

    }


}
