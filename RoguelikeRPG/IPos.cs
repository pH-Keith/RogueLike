﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoguelikeRPG
{
    /// <summary>
    /// Interface that holds the positional values.
    /// </summary>
    interface IPos
    {
        int X { get; set; }
        int Y { get; set; }
    }
}
