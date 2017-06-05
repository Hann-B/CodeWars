using System;

namespace TheCouponCode_Codewars
{
    class Program
    {
        public static class Kata
        {
            public static bool CheckCoupon(string enteredCode, string correctCode, string currentDate, string expirationDate)
            {
                var isValid = false;
                if(enteredCode==correctCode && DateTime.Parse(currentDate)<=DateTime.Parse(expirationDate))
                {
                    return isValid=true;
                }
                return isValid;
            }
        }


        static void Main(string[] args){}
    }
}