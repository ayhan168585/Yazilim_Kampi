using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        public SuccessResult(bool success, string message) : base(true, message)
        {
        }

        public SuccessResult(bool success) : base(true)
        {
        }
        public SuccessResult(string message) : base(true)
        {
        }
        public SuccessResult() : base(true)
        {
        }
    }
}
