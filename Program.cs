/// Week 2 Lab 2
/// File Name: Lab2.cs
/// @author: Nasi Bode
/// 
/// Problem Statement: Create a program that will output how many candy bars and gumballs the user can get if they spend all coupons on 
/// candybars first, then gumballs, with the remainder of the coupons to the screen
/// 
///
/// Overall Plan: 
/// 1. Print an inital welcoming message to the screen
/// 2. Define the int variables for the number of coupons, the number of ccandybars, the num of gumballs, and
/// the amount of coupons after candybars and gumballs
/// 3. Calculate the remaining coupons after buying candybars using the modular % 
/// 4. Calculate the amount of gumballs the user can get using the coupons leftover from buying candybars
/// 5. Calculate any leftover copons
/// 6. Print the number of coupons, the number of candybars, the num of gumballs, and the leftover coupons to the screen
/// 


using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num_coupons = 108;
            int num_coupons_after_candyBars, num_coupons_after_gumballs, num_candy_bar, num_gumballs;
            //integer division below discards any remainder
            num_candy_bar = num_coupons / 10;
            //calculater the remaining coupons
            num_coupons_after_candyBars = num_coupons % 10;

            //calculate gumballs
            num_gumballs = num_coupons_after_candyBars / 3;

            //calculate any leftover coupons
            num_coupons_after_gumballs = num_coupons_after_candyBars % 3;

            Console.WriteLine("Your {0} coupons can be redemmed for {1} candy bars and {2} gumballs with {3} coupons leftover", num_coupons, num_candy_bar, num_gumballs, num_coupons_after_gumballs);




            Console.ReadLine();


        }
    }
}
