using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace testEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //using example for test #1
            #region test1
            Console.WriteLine("enter positive digit");
            try
            {
                int tmp=Convert.ToInt32(Console.ReadLine());//get digit from user
                if (tmp >= 0)//check positive number
                    Console.WriteLine(CatlanTest.Catalan(tmp));//function for solved test#1
                else
                    MessageBox.Show("variable must be a positive");//if not positive
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Enter number, please\n{ex.Message}");//if not a digit
            }
            #endregion
            //using example for test #3
            #region test3
            Console.WriteLine("Enter digit for factorial");
            try
            {
               int tmp3 =Convert.ToInt32(Console.ReadLine());//get digit from user
                
                if (tmp3 >= 0)//check positive number
                    Console.WriteLine(Factorial.FactSum(Factorial.Fact(tmp3)));//function for solved test#3
                
                else
                    MessageBox.Show("variable must be a positive");//if not positive
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Enter number, please\n{ex.Message}");//if not a digit
            }
#endregion

        }
    }
    /*********************/
    //create class for test #1
    class CatlanTest {
        //The simplest solution is the Catalan number
        public static int Catalan(int digit) {
            int res = 0;//variable for counting result 
            //recursion
            if (digit <= 0)
            {
                return 1;
            }
            for (int i = 0; i < digit; i++)
            {
                res += Catalan(i) * Catalan((digit - 1) - i);
            }
            return res;
        }
    }
    /*************************/
    //create class for test #3
    class Factorial {
        //recurcion
        public static BigInteger Fact(BigInteger tmp3) {//function counting factorial
            return tmp3 == 0 ? 1 : tmp3 * Fact(tmp3 - 1);//ternary operator
        }
        public static int FactSum(BigInteger integer) {//function counting sum of digit factorial
            return integer.ToString().Sum(digit => digit - '0');//parse to string and add it by character
        }
       
    }
    /************************************/
    //data for test #2
    //create class for saving vertex graph
}
