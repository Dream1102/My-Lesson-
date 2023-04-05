using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

//namespace _3_Modul._1_Dars.HomeTasks
//{

//    class Calculate
//    {
//        // Declare a delegate
//        delegate double CalculateSimpleInterest(double para1, double para2, double para3);
//        static CalculateSimpleInterest dObjSI = getTotalInterest;

//        static void Main(string[] args)
//        {
//            double SI;
//            //Calculating simple interest
//            SI = dObjSI.Invoke(120, 1, 3.25);
//            //using multicast delegate by invoking method getInterestRatePerYear()
//            dObjSI += new CalculateSimpleInterest(getInterestRatePerYear);
//            double Rate = dObjSI.Invoke(SI, 120, 1);
//            Console.WriteLine("APR rate is {0}", Rate);
//            //using multicast delegate by invoking method getInterestTimeSpan()
//            dObjSI += new CalculateSimpleInterest(getInterestTimeSpan);
//            double TimeSpan = dObjSI.Invoke(SI, 120, 3.25);
//            Console.WriteLine("Time Span is {0}", TimeSpan);


//            Console.ReadKey();
//        }

//        /// <summary>
//        /// Gets the total interest.
//        /// </summary>
//        /// <param name="p" />The Principal.
//        /// <param name="t" />The Time.
//        /// <param name="r" />The Rate.
//        /// <returns>Total Interest
//        static double getTotalInterest(double p, double t, double r)
//        {
//            return (p * t * r) / 100;
//        }
//        /// <summary>
//        /// Gets the interest rate per year.
//        /// </summary>
//        /// <param name="SI" />The Simple Interest.
//        /// <param name="p" />The Principal.
//        /// <param name="t" />The Time.
//        /// <returns>Interest rate per year
//        static double getInterestRatePerYear(double SI, double p, double t)
//        {
//            return (SI * 100) / (p * t);
//        }
//        /// <summary>
//        /// Gets the interest time span.
//        /// </summary>
//        /// <param name="SI" />The Simple Interest.
//        /// <param name="p" />The Principal.
//        /// <param name="r" />The Rate.
//        /// <returns>Interest time span
//        static double getInterestTimeSpan(double SI, double p, double r)
//        {
//            return (SI * 100) / (p * r);
//        }

//    }
//}
