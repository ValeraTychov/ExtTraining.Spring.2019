﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    public interface IPasswordCheckerService
    {
        bool VerifyPassword(string password, out string message);
    }
}
