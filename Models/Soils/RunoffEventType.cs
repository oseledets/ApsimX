﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Soils
{
    public class RunoffEventType
    {
        public double runoff;
    }

    public delegate void RunoffEventDelegate(RunoffEventType Runoff);
}
