﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UserManagement.SharedKernel.Returns
{
    public abstract class ControlledException : Exception
    {
        public abstract int StatusCodeResult { get; }
        public abstract string DefaultMessage { get; }
    }
}
