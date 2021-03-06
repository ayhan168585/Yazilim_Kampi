﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data, bool success, string message) : base(data, true, message)
        {
        }

        
        public SuccessDataResult(T data, string message) : base(data,true,message)
        {
        }

        public SuccessDataResult(T data, bool success) : base(data, true)
        {
        }
        public SuccessDataResult(bool success, string message) : base(default, true, message)
        {
        }

        public SuccessDataResult(bool success) : base(default, true)
        {
        }
        public SuccessDataResult(string message) : base(default,true)
        {
        }

        public SuccessDataResult() : base(default,true)
        {
        }
    }
}
