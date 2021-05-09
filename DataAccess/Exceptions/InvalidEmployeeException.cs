using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Exceptions
{
    public class InvalidEmployeeException : Exception
    {
        const string InvalidEmployeeId = "Invalid Employee Id";
        public InvalidEmployeeException() : base (InvalidEmployeeId)
        {

        }
    }
}
