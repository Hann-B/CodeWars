using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodVsEvil
{
    public class Kata
    {
        public static string GoodVsEvil(string good, string evil)
        {
            var rv = String.Empty;
            var gTot = 0;
            int[] gWorth = { 1, 2, 3, 3, 4, 10 };
            int[] gArr = new int[6];
            var goodSide = good.Split(" ".ToCharArray()).Select(Int32.Parse).ToArray();
            for (int g = 0; g < goodSide.Length; g++)
            {
                //"1 1 1 1 1 1" * "1 2 3 3 4 10"
                gArr[g] = gWorth[g] * goodSide[g];
            }
            gTot = gArr.Sum();

            var eTot = 0;
            int[] eWorth = { 1, 2, 2, 2, 3, 5, 10 };
            int[] eArr = new int[7];
            var evilSide = evil.Split(" ".ToCharArray()).Select(Int32.Parse).ToArray();
            for (int e = 0; e < evilSide.Length; e++)
            {
                //"1 1 1 1 1 1 1" * "1 2 2 2 3 5 10"
                eArr[e] = eWorth[e] * evilSide[e];
            }
            eTot = eArr.Sum();

            if (gTot > eTot)
            {
                rv = "Battle Result: Good triumphs over Evil";
            }
            else if (gTot < eTot)
            {
                rv = "Battle Result: Evil eradicates all trace of Good";
            }
            else
            {
                rv = "Battle Result: No victor on this battle field";
            }
            return rv;
        }

        //LINQ Solution

        //public static string GoodVsEvil(string good, string evil)
        //{
        //    var gWorth = new[] { 1, 2, 3, 3, 4, 10 };
        //    var eWorth = new[] { 1, 2, 2, 2, 3, 5, 10 };
        //    var g = good.Split(' ').Select(int.Parse).Zip(gWorth, (f, s) => f * s).Sum();
        //    var b = evil.Split(' ').Select(int.Parse).Zip(eWorth, (f, s) => f * s).Sum();
        //    return (g > b) ? "Battle Result: Good triumphs over Evil" : ((g == b) ? "Battle Result: No victor on this battle field" : "Battle Result: Evil eradicates all trace of Good");
        //}
    }
}
