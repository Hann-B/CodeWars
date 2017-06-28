using System;

namespace BouncingBalls_Codewars
{
    class Program
    {
        public class BouncingBall
        {

            public static int bouncingBall(double h, double bounce, double window)
            {
                var rv = 0;
                if(h>0 && 0<bounce && bounce>1 && window < h)
                {
                    //for (int i = 0; i < window; i++)
                    //{
                    //    var rebounce = h * Math.Pow(bounce, i);
                    //}
                    do
                    {

                    }
                    while (window<rebounce);
                }
                else
                {
                    rv=-1;
                }
                return rv;
            }
        }
    }
}