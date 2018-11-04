using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class _Delegate
    {
        /// <summary>
        /// Example of a delegate with 3 params
        /// </summary>
        /// <param name="arg0"></param>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        /// <returns></returns>
        delegate double Dfunc(int arg0, double arg1, bool arg2);

        /// <summary>
        /// Funciton satisfy for a delegate
        /// </summary>
        /// <param name="a0"></param>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns></returns>
        static double func(int a0, double a1, bool a2)
        {
            if (a2)
                return a0 * a1;
            else
                return a1 - a1 / a0;
        }

        /// <summary>
        /// Method with delegate typed arg (with MY delegate)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="a1"></param>
        /// <param name="flag"></param>
        /// <param name="inp"></param>
        /// <param name="f"></param>
        /// <returns></returns>
        static string build(int a, double a1, bool flag, string inp, Dfunc f)
        {
            return inp + "var equals " + f(a, a1, flag).ToString();
        }
         
        /// <summary>
        /// Method with Func<> arg
        /// </summary>
        /// <param name="a"></param>
        /// <param name="a1"></param>
        /// <param name="flag"></param>
        /// <param name="inp"></param>
        /// <param name="f"></param>
        /// <returns></returns>
        static string build_func(int a, double a1, bool flag, string inp, Func<int, double, bool, double> f)
        {
            return inp + "var equals " + f(a, a1, flag).ToString();
        }
            
        static void Main(string[] args)
        {
            //params for delegate-argumented function
            string inp = "The weather is fine, and ";
            int a = 3;
            double a1 = 5.23;
            bool flag = true;

            //call with delegate-typed method
            Console.WriteLine(build(a, a1, flag, inp, func));
            //call with lambda-function
            Console.WriteLine(build(a, a1, flag, inp,
                                    (int b, double b1, bool b2) =>
                                    {
                                        if (b2)
                                            return b1 - b;
                                        else
                                            return b + b1;
                                    }));

            Console.WriteLine();

            //call with delegate-typed method
            Console.WriteLine(build_func(a, a1, flag, inp, func));
            //call with lambda-function
            Console.WriteLine(build_func(a, a1, flag, inp,
                                    (int b, double b1, bool b2) =>
                                    {
                                        if (b2)
                                            return b1 - b;
                                        else
                                            return b + b1;
                                    }));

            Console.ReadKey(); //delay for a user
        }
    }
}
