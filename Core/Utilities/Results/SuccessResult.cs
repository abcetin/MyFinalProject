using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message):base(true,message) //base result sınıfının çift parametreli olanına git demek
        {
        }

        public SuccessResult() : base(true) //result sınıfının tek parametreli olanına git demek
        {
        }
    }
}
