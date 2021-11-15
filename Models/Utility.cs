using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApplication.Models
{
    public class Utility
    {
        public static string CheckTemparature(int temp)
        {
            string res = "";
            if (temp >= 100)
              res= "Person having Fever";
            if (temp < 100)
                res= "Person having  no Fever";
            return res;
        }
    }
}
