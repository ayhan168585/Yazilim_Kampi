using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T>:DataResult<T>
    {
        public ErrorDataResult(T data, bool success, string message) : base(data, false, message)
        {
        }


        public ErrorDataResult(T data, string message) : base(data, false, message)
        {
        }

        public ErrorDataResult(T data, bool success) : base(data, false)
        {
        }
        public ErrorDataResult(bool success, string message) : base(default, false, message)
        {
        }

        public ErrorDataResult(bool success) : base(default, false)
        {
        }
        public ErrorDataResult(string message) : base(default, false)
        {
        }

        public ErrorDataResult() : base(default, false)
        {
        }
    }
}
