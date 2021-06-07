using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    class Program
    {
      
            // 1.Creating a delegate
        public delegate int MyDelegate(int num1, int num2);
        static void Main(string[] args)
        {
            //3.Create Object for delegate
            MyDelegate obj = new MyDelegate(AddNumbers); //Function Pointer // obj += new MyDelegate(SubNumbers);co



            //Invoke delegate
            int resDel = obj(55, 44);

            Console.WriteLine("result is:" + resDel);
            Console.ReadLine();

            int res = AddNumbers(55, 44);
            int res2 = SubNumbers(55, 44);
            int res3 = MultNumbers(55, 44);
        }




        //2. Creating Methods that will support the Delegate parameter
        public static int AddNumbers(int num1, int numberr2)
        {
            return num1 + numberr2;
        }
        public static int SubNumbers(int num1, int numberr2)
        {
            return num1 + numberr2;
        }
        public static int MultNumbers(int num1, int numberr2)
        {
            return num1 + numberr2;
        }
    }
    }

