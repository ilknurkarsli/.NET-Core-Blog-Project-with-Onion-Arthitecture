using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2_BlogApplication.Exceptions
{
    public class MyException : Exception
    {
        public MyException() : base("sistemde bir hata gerceklesti")
        {
            
        }
        public MyException(string message) : base(message)
        {
            
        }
        public MyException(Exception exception) : base(exception.Message)
        {
            
        }
    }
}