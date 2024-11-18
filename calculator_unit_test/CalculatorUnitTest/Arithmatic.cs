using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorUnitTest
{
    public class Arithmatic
    {
        public int sum(int x, int y)
        {
            return x + y;
        } 
        public int sub(int x, int y)
        {
            return x - y;
        } 
        public int mul(int x, int y)
        {
            return x * y;
        } 
        public int div(int x, int y)
        {
            return x / y;
        }

        public virtual bool checkDigitsOnly()//using virtual coz overriding the method
        {
            return false;
        }
    }
}
