using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    class CalcException : Exception
    {
        public enum CalcErrorCode
        {
            InvalidNumberText,
            DevideByZero
        }

        public CalcErrorCode Error { get; set; }
        // base is like super or 
        public CalcException(String message, CalcErrorCode error) : base(message)
        {
            Error = error;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //just throw the exception
                throw new CalcException("Calc failed", CalcException.CalcErrorCode.InvalidNumberText);

            }
            catch (CalcException ex)
            {
                Console.WriteLine("Error: {0}", ex.Error);
            }

            try
            {
                //just throw the exception
                throw new CalcException("Calc failed", CalcException.CalcErrorCode.DevideByZero);

            }
            catch (CalcException ex) when (ex.Error == CalcException.CalcErrorCode.InvalidNumberText)
            {
                //no catch here because of when 
            }
            catch (CalcException ex) when (ex.Error == CalcException.CalcErrorCode.DevideByZero)
            {
                Console.WriteLine("Error: {0}", ex.Error);
                Console.ReadKey();
            }
        }
    }
}
